using DevExpress.XtraSplashScreen;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Fake_News_Detector
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        ArrayList twtids = new ArrayList();
        ArrayList twtusrnme = new ArrayList();
        ArrayList twtusrimg = new ArrayList();
        ArrayList twtmsg = new ArrayList();
        ArrayList twtattchmnt = new ArrayList();
        ArrayList twtdte = new ArrayList();
        ArrayList twt_rtwts = new ArrayList();
        ArrayList twt_favs = new ArrayList();
        ArrayList twt_usrfrnds = new ArrayList();
        ArrayList twt_usrfllws = new ArrayList();
        ArrayList twt_usrage = new ArrayList();
        ArrayList twt_usrstscount = new ArrayList();
        ArrayList twt_urls = new ArrayList();
        ArrayList tone_sub = new ArrayList();

        private Boolean is_satire = false;

        DataTable tblTweets = new DataTable();

        

        public frmMain()
        {
            InitializeComponent();

            //Initalize the DataTable Columns
            tblTweets.Columns.Add("Date Created");
            tblTweets.Columns.Add("Tweet");

            grdTweets.DataSource = tblTweets;

            //Initialize the Labels
            lblAuthorAna.Text = "";
            lblClassify.Text = "";
            lblRefPageScore.Text = "";
            lblRetweets.Text = "";
            lblSatireScore.Text = "";
            lblSources.Text = "";
            lblConAna.Text = "";
            lblEmotion.Text = "";

                       
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
            if (checkConn())
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1));
                SplashScreenManager.Default.SetWaitFormDescription("Fetching Relevant Tweets...");
                bgwGetTweets.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("No Connection to Twitter");
            }
        }

        private static Boolean checkConn()
        {
            try
            {
                Ping x = new Ping();
                PingReply reply = x.Send(IPAddress.Parse("104.244.45.1"), 10000);
                if (reply.Status == IPStatus.Success)
                {
                    return true;
                }
            }

            catch { }

            return false;
        }

        private String getTweets()
        {
            String rslt = null;
            String query = "News Kenya";
            try
            {
                string url = "https://api.twitter.com/1.1/search/tweets.json";

                // oauth application keys
                var oauth_token = "2228281075-ACm6Vt5CHN2FRFrfP15FmDi3CxNI6rjeDvVt9Ju"; //"insert here...";
                var oauth_token_secret = "DsfpggOCoPPPtFGKVQ3EaZgOWM2LL9tSBhfDOfT1tU4Ny"; //"insert here...";
                var oauth_consumer_key = "LnUIYhkz5RRG5dYwtQ6g3Q";// = "insert here...";
                var oauth_consumer_secret = "13pjrYRG1LtZ1vgNfCISi9fHhSR53sHuPpqCfPE";// = "insert here...";

                // oauth implementation details
                var oauth_version = "1.0";
                var oauth_signature_method = "HMAC-SHA1";

                // unique request details
                var oauth_nonce = Convert.ToBase64String(new ASCIIEncoding().GetBytes(DateTime.Now.Ticks.ToString()));
                var timeSpan = DateTime.UtcNow
                    - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                var oauth_timestamp = Convert.ToInt64(timeSpan.TotalSeconds).ToString();


                // create oauth signature
                var baseFormat = "";
                var baseString = "";

                if (gridView1.RowCount == 0)
                {
                    baseFormat = "count={7}&oauth_consumer_key={0}&oauth_nonce={1}&oauth_signature_method={2}" +
                                    "&oauth_timestamp={3}&oauth_token={4}&oauth_version={5}&q={6}";

                    baseString = string.Format(baseFormat,
                                            oauth_consumer_key,
                                            oauth_nonce,
                                            oauth_signature_method,
                                            oauth_timestamp,
                                            oauth_token,
                                            oauth_version,
                                            Uri.EscapeDataString(query),
                                            Uri.EscapeDataString("100")
                                            );
                }
                else
                {
                    baseFormat = "count={8}&oauth_consumer_key={0}&oauth_nonce={1}&oauth_signature_method={2}" +
                                                        "&oauth_timestamp={3}&oauth_token={4}&oauth_version={5}&q={6}&since_id={7}";
                    baseString = string.Format(baseFormat,
                                           oauth_consumer_key,
                                           oauth_nonce,
                                           oauth_signature_method,
                                           oauth_timestamp,
                                           oauth_token,
                                           oauth_version,
                                           Uri.EscapeDataString(query),
                                           Uri.EscapeDataString(twtids[0].ToString()),
                                           Uri.EscapeDataString("100")
                                           );
                }



                baseString = string.Concat("GET&", Uri.EscapeDataString(url), "&", Uri.EscapeDataString(baseString));

                var compositeKey = string.Concat(Uri.EscapeDataString(oauth_consumer_secret),
                                        "&", Uri.EscapeDataString(oauth_token_secret));

                string oauth_signature;
                using (HMACSHA1 hasher = new HMACSHA1(ASCIIEncoding.ASCII.GetBytes(compositeKey)))
                {
                    oauth_signature = Convert.ToBase64String(
                        hasher.ComputeHash(ASCIIEncoding.ASCII.GetBytes(baseString)));
                }

                // create the request header
                var headerFormat = "OAuth oauth_nonce=\"{0}\", oauth_signature_method=\"{1}\", " +
                                   "oauth_timestamp=\"{2}\", oauth_consumer_key=\"{3}\", " +
                                   "oauth_token=\"{4}\", oauth_signature=\"{5}\", " +
                                   "oauth_version=\"{6}\"";

                var authHeader = string.Format(headerFormat,
                                        Uri.EscapeDataString(oauth_nonce),
                                        Uri.EscapeDataString(oauth_signature_method),
                                        Uri.EscapeDataString(oauth_timestamp),
                                        Uri.EscapeDataString(oauth_consumer_key),
                                        Uri.EscapeDataString(oauth_token),
                                        Uri.EscapeDataString(oauth_signature),
                                        Uri.EscapeDataString(oauth_version)
                                );


                ServicePointManager.Expect100Continue = false;

                // make the request
                if (twtids.Count == 0)
                {
                    var postBody = "q=" + Uri.EscapeDataString(query) + "&count=" + Uri.EscapeDataString("100");//
                    url += "?" + postBody;
                }
                else
                {
                    var postBody = "q=" + Uri.EscapeDataString(query) + "&since_id=" + twtids[0] + "&count=100";//
                    url += "?" + postBody;
                }

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("Authorization", authHeader);
                request.Method = "GET";
                request.ContentType = "application/x-www-form-urlencoded";
                var response = (HttpWebResponse)request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());

                rslt = reader.ReadToEnd().ToString();

                Debug.Write(rslt, "Tweet Results");
            }
            catch (Exception err)
            {
                Debug.Write(err.Message, "Fetching Tweets Error");
            }

            return rslt;
        }

        private void bgwGetTweets_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = getTweets();
        }

        private void bgwGetTweets_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            String rslts = e.Result.ToString();

            dynamic dynObj = JsonConvert.DeserializeObject(rslts);
             
            foreach (var tweet in dynObj.statuses)
            {
                string tweetmsg = tweet.text;

                if (!tweet_in_List(tweetmsg))
                {
                    twtdte.Add(tweet.created_at);
                    twtmsg.Add(tweet.text);
                    twtusrnme.Add(tweet.user.screen_name);
                    String img = tweet.user.profile_image_url;
                    twtusrimg.Add(img.Replace("_normal", ""));
                    twtids.Add(tweet.id);
                    twt_rtwts.Add(tweet.retweet_count);
                    twt_favs.Add(tweet.favorite_count);
                    twt_usrage.Add(tweet.user.created_at);
                    twt_usrfllws.Add(tweet.user.followers_count);
                    twt_usrfrnds.Add(tweet.user.friends_count);
                    twt_usrstscount.Add(tweet.user.statuses_count);

                    try
                    {
                        twtattchmnt.Add(tweet.entities.media[0].media_url);
                    }
                    catch
                    {
                        twtattchmnt.Add("none");
                    }

                    tblTweets.Rows.Add(tweet.created_at, tweet.text);

                }
            }

            grdTweets.RefreshDataSource();

            SplashScreenManager.CloseForm();

            if (tblTweets.Rows.Count > 0)
            {
                MessageBox.Show("Click any of the Tweets to begin analysis", Application.ProductName,
                                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private Boolean tweet_in_List(String tweet)
        {
            for (int i = 0; i < twtmsg.Count; i++)
            {
                if (twtmsg[i].ToString().Equals(tweet))
                {
                    return true;
                }
            }
                return false;
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int pos = gridView1.FocusedRowHandle;

            grdTweets.Enabled = false;

            //Evaluate tweet popularity
            ppPopular.Visible = true;
            bgwEvaPopularity.RunWorkerAsync(pos);

            //Evaluate Author Authenticity
            ppAuthorAna.Visible = true;
            bgwAnthorAna.RunWorkerAsync(pos);

            //Evaluate Sources
            ppSources.Visible = true;
            bgwSourceAna.RunWorkerAsync(pos);
        }

        private void bgwEvaPopularity_DoWork(object sender, DoWorkEventArgs e)
        {
            int rt_count = Convert.ToInt32(twt_rtwts[Convert.ToInt32(e.Argument)]);

            e.Result = rt_count;

            
        }

        private void bgwEvaPopularity_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int rt_count = Convert.ToInt32(e.Result as String);

            if (rt_count == 0)
            {
                //Not Popular
                lblRetweets.Text = "Not Popular";
            }

            else if (rt_count > 0 && rt_count < 50)
            {
                //Mildly popular
                lblRetweets.Text = "Mildly Popular";
            }

            else if (rt_count >= 50 && rt_count < 200)
            {
                //Popular
                lblRetweets.Text = "Popular";
            }

            else if (rt_count >= 200 && rt_count < 500)
            {
                //Very Popular
                lblRetweets.Text = "Very Popular";
            }

            else if (rt_count > 500 && rt_count < 100000)
            {
                //Wildly Popular
                lblRetweets.Text = "Wildly Popular";
            }

            else if (rt_count >= 100000)
            {
                //Treading
                lblRetweets.Text = "Treading";
            }

            ppPopular.Visible = false;

            grdTweets.Enabled = true;
        }

        private void bgwAnthorAna_DoWork(object sender, DoWorkEventArgs e)
        {
            string Const_TwitterDateTemplate = "ddd MMM dd HH:mm:ss +ffff yyyy";

            int pos = Convert.ToInt32(e.Argument.ToString());

            int score = 0;

            string rslt = null;

            //Establish the age of the account
            DateTime dt_created = DateTime.ParseExact(twt_usrage[pos].ToString(),Const_TwitterDateTemplate,CultureInfo.InvariantCulture);
            DateTime dt_now = DateTime.Now;

            int age_in_days = (dt_now.Date - dt_created.Date).Days;

            //Establish number of tweets account has posted
            int twt_nos = Convert.ToInt32(twt_usrstscount[pos].ToString());

            //Establish number of followers account has
            int twt_frnds = Convert.ToInt32(twt_usrfrnds[pos].ToString());

            //Establish number of friends account has
            int twt_follwing = Convert.ToInt32(twt_usrfllws[pos].ToString());

            //Evaluate Account
            if (age_in_days < 90)
            {
                score++;
            }
            else if (age_in_days >= 90)
            {
                score = score + 2;
                
            }

            if (twt_nos > 1000)
            {
                score = score + 2;
            }

            else
            {
                score++;
            }

            if (twt_follwing > twt_frnds)
            {
                score+=2;
            }
            else if (twt_follwing < twt_frnds)
            {
                score++;
            }

            //establish mean

            if (score >= 6)
            {
                rslt = "Account is Highly Suspect";
            }
            else if (score < 6 && score >= 3)
            {
                rslt = "Account is Moderatly Suspect";
            }
            else if (score < 3)
            {
                rslt = "Account is not Suspect";
            }

            e.Result = rslt;

        }

        private void bgwAnthorAna_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ppAuthorAna.Visible = false;

            lblAuthorAna.Text = e.Result as String;

            lblAuthorAna.Visible = true;
        }

        

        private void extract_URL(String tweet)
        {
            twt_urls.Clear();

            var links = tweet.Split("\t\n ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Where(s => s.StartsWith("http://") || s.StartsWith("www.") || s.StartsWith("https://"));
            foreach (string s in links)
            {
                twt_urls.Add(s);
            }
        }

        private void bgwSourceAna_DoWork(object sender, DoWorkEventArgs e)
        {
            tone_sub.Clear();

            //Check if satire
            if (twtmsg[Convert.ToInt32(e.Argument.ToString())].ToString().Contains("satire"))
            {
                is_satire = true;
            }
            else
            {
                is_satire = false;
            }

            //Extract url from tweet
            string tweet = twtmsg[Convert.ToInt32(e.Argument.ToString())].ToString();

            //Determine sensetionalism in tweet

            string rslt_ana = toneAnalyse(tweet).ToString();

            dynamic dynObj = JsonConvert.DeserializeObject(rslt_ana);

            try
            {
                foreach (var tone in dynObj.document_tone.tones)
                {
                    tone_sub.Add(tone.tone_name);
                }
            }
            catch { }

            rslt_ana = textAnalyse(tweet);

            dynObj = JsonConvert.DeserializeObject(rslt_ana);

            try
            {
                foreach (var tone in dynObj.features.entities)
                {

                }
            }
            catch { }

            extract_URL(tweet);

            if (twt_urls.Count > 0)
            {
                //Evaluate the url for key words

                //Check if url is image 

                //if image perform image search on google

                //Get the first 3 results

                //if only one result dismiss claim

                //Open the links and scrab the page for the keywords extracted from the tweet

                //Get the Image linked to the url

                //Compare the two images see if they match

                //If they do compare the two headings for similarities

                //Do the same for the next two results

                //Establish a match score from all 3 sources

                if (twt_urls.Count == 1)
                {
                    e.Result = twt_urls.Count + " Link Present";
                }
                else if (twt_urls.Count > 1)
                {
                    e.Result = twt_urls.Count + " Links Present";
                }

            }
            else
            {
                e.Result = "No Sources Attached - High likely hood this is personal opinion";
            }
        }

        private object toneAnalyse(string tweet)
        {
            string _username = "1f3e2345-b6bd-4202-9c83-37472ec61d48";
            string _password = "jA3UqXeBVAJk";

            var client = new RestClient("https://gateway.watsonplatform.net/tone-analyzer/api/v3/tone?version="+DateTime.Now.ToString("yyyy-MM-dd"));
            var request = new RestRequest(Method.GET);
            request.Credentials = new NetworkCredential(_username, _password);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("cache-control", "no-cache");
            request.AddQueryParameter("text", tweet);
            //request.AddParameter("application/x-www-form-urlencoded", "bodykey=bodyval", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        private string textAnalyse(string tweet)
        {
            string _username = "747dfa31-5d3c-4431-8ca8-c91e82a59bd1";
            string _password = "lzuKtUcvdt8g";

            var client = new RestClient("https://gateway.watsonplatform.net/natural-language-understanding/api/v1/analyse?version=" + DateTime.Now.ToString("yyyy-MM-dd"));
            var request = new RestRequest(Method.POST);
            request.Credentials = new NetworkCredential(_username, _password);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("cache-control", "no-cache");
            request.AddQueryParameter("text", tweet);
            //request.AddParameter("application/json", "bodykey=bodyval", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        private void bgwSourceAna_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string rslt = e.Result.ToString();

            lblSources.Text = rslt;

            ppSources.Visible = false;

            //Check for Satire
            if (is_satire)
            {
                lblSatireScore.Text = "Comment is satire";
            }
            else
            {
                lblSatireScore.Text = "Comment is not satire";
            }

            lblSatireScore.Visible = true;

            //Evaluate the Comment emotion
            if (tone_sub.Count > 0)
            {
                if (tone_sub.Count == 1)
                {
                    lblEmotion.Text = tone_sub[0].ToString();
                }

                else
                {
                    string emo = null;

                    for (int i = 0; i < tone_sub.Count; i++)
                    {
                        if (emo == null)
                        {
                            emo = tone_sub[i].ToString();
                        }
                        else
                        {
                            emo += tone_sub[i] + ",";
                        }
                        
                    }

                    lblEmotion.Text =  emo;
                    
                    //TODO: Make a connection between emotion and sensetionalism 
                }
            }
            else
            {
                lblEmotion.Text = "No emotion";
            }

            lblEmotion.Visible = true;
        }
    }
}
