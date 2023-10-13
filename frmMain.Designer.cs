namespace Fake_News_Detector
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdTweets = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ppRefPageScore = new DevExpress.XtraWaitForm.ProgressPanel();
            this.lblRefPageScore = new DevExpress.XtraEditors.LabelControl();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ppSatireScore = new DevExpress.XtraWaitForm.ProgressPanel();
            this.lblSatireScore = new DevExpress.XtraEditors.LabelControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ppSources = new DevExpress.XtraWaitForm.ProgressPanel();
            this.lblSources = new DevExpress.XtraEditors.LabelControl();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ppAuthorAna = new DevExpress.XtraWaitForm.ProgressPanel();
            this.lblAuthorAna = new DevExpress.XtraEditors.LabelControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ppPopular = new DevExpress.XtraWaitForm.ProgressPanel();
            this.lblRetweets = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ppClassify = new DevExpress.XtraWaitForm.ProgressPanel();
            this.lblClassify = new DevExpress.XtraEditors.LabelControl();
            this.bgwGetTweets = new System.ComponentModel.BackgroundWorker();
            this.bgwEvaPopularity = new System.ComponentModel.BackgroundWorker();
            this.bgwAnthorAna = new System.ComponentModel.BackgroundWorker();
            this.bgwSourceAna = new System.ComponentModel.BackgroundWorker();
            this.bgwRefPageAna = new System.ComponentModel.BackgroundWorker();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblEmotion = new DevExpress.XtraEditors.LabelControl();
            this.lblConAna = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTweets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.grdTweets);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 576);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tweets of Interest";
            // 
            // grdTweets
            // 
            this.grdTweets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTweets.Location = new System.Drawing.Point(3, 17);
            this.grdTweets.MainView = this.gridView1;
            this.grdTweets.Name = "grdTweets";
            this.grdTweets.Size = new System.Drawing.Size(294, 556);
            this.grdTweets.TabIndex = 0;
            this.grdTweets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdTweets;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(330, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 576);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.ppRefPageScore);
            this.groupBox7.Controls.Add(this.lblRefPageScore);
            this.groupBox7.Location = new System.Drawing.Point(7, 463);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(647, 100);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Reference Page Score";
            // 
            // ppRefPageScore
            // 
            this.ppRefPageScore.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ppRefPageScore.Appearance.Options.UseBackColor = true;
            this.ppRefPageScore.Description = "Processing...";
            this.ppRefPageScore.Location = new System.Drawing.Point(192, 20);
            this.ppRefPageScore.Name = "ppRefPageScore";
            this.ppRefPageScore.Size = new System.Drawing.Size(246, 67);
            this.ppRefPageScore.TabIndex = 1;
            this.ppRefPageScore.Text = "progressPanel1";
            this.ppRefPageScore.Visible = false;
            // 
            // lblRefPageScore
            // 
            this.lblRefPageScore.Appearance.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold);
            this.lblRefPageScore.Location = new System.Drawing.Point(148, 29);
            this.lblRefPageScore.Name = "lblRefPageScore";
            this.lblRefPageScore.Size = new System.Drawing.Size(238, 42);
            this.lblRefPageScore.TabIndex = 0;
            this.lblRefPageScore.Text = "labelControl1";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.ppSatireScore);
            this.groupBox8.Controls.Add(this.lblSatireScore);
            this.groupBox8.Location = new System.Drawing.Point(346, 364);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(308, 93);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Satire Score";
            // 
            // ppSatireScore
            // 
            this.ppSatireScore.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ppSatireScore.Appearance.Options.UseBackColor = true;
            this.ppSatireScore.Description = "Processing...";
            this.ppSatireScore.Location = new System.Drawing.Point(36, 20);
            this.ppSatireScore.Name = "ppSatireScore";
            this.ppSatireScore.Size = new System.Drawing.Size(246, 67);
            this.ppSatireScore.TabIndex = 1;
            this.ppSatireScore.Text = "progressPanel1";
            this.ppSatireScore.Visible = false;
            // 
            // lblSatireScore
            // 
            this.lblSatireScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSatireScore.Appearance.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold);
            this.lblSatireScore.Location = new System.Drawing.Point(10, 34);
            this.lblSatireScore.Name = "lblSatireScore";
            this.lblSatireScore.Size = new System.Drawing.Size(238, 42);
            this.lblSatireScore.TabIndex = 0;
            this.lblSatireScore.Text = "labelControl1";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.ppSources);
            this.groupBox5.Controls.Add(this.lblSources);
            this.groupBox5.Location = new System.Drawing.Point(7, 364);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(333, 93);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Number of Sources";
            // 
            // ppSources
            // 
            this.ppSources.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ppSources.Appearance.Options.UseBackColor = true;
            this.ppSources.Description = "Processing...";
            this.ppSources.Location = new System.Drawing.Point(48, 20);
            this.ppSources.Name = "ppSources";
            this.ppSources.Size = new System.Drawing.Size(246, 67);
            this.ppSources.TabIndex = 1;
            this.ppSources.Text = "progressPanel1";
            this.ppSources.Visible = false;
            // 
            // lblSources
            // 
            this.lblSources.Appearance.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold);
            this.lblSources.Location = new System.Drawing.Point(10, 33);
            this.lblSources.Name = "lblSources";
            this.lblSources.Size = new System.Drawing.Size(238, 42);
            this.lblSources.TabIndex = 0;
            this.lblSources.Text = "labelControl1";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.ppAuthorAna);
            this.groupBox6.Controls.Add(this.lblAuthorAna);
            this.groupBox6.Location = new System.Drawing.Point(346, 127);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(308, 100);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Author/User Analysis";
            // 
            // ppAuthorAna
            // 
            this.ppAuthorAna.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ppAuthorAna.Appearance.Options.UseBackColor = true;
            this.ppAuthorAna.Description = "Processing...";
            this.ppAuthorAna.Location = new System.Drawing.Point(36, 20);
            this.ppAuthorAna.Name = "ppAuthorAna";
            this.ppAuthorAna.Size = new System.Drawing.Size(246, 67);
            this.ppAuthorAna.TabIndex = 1;
            this.ppAuthorAna.Text = "progressPanel1";
            this.ppAuthorAna.Visible = false;
            // 
            // lblAuthorAna
            // 
            this.lblAuthorAna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuthorAna.Appearance.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold);
            this.lblAuthorAna.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAuthorAna.Location = new System.Drawing.Point(6, 20);
            this.lblAuthorAna.Name = "lblAuthorAna";
            this.lblAuthorAna.Size = new System.Drawing.Size(296, 52);
            this.lblAuthorAna.TabIndex = 0;
            this.lblAuthorAna.Text = "labelControl1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ppPopular);
            this.groupBox4.Controls.Add(this.lblRetweets);
            this.groupBox4.Location = new System.Drawing.Point(7, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Popularity";
            // 
            // ppPopular
            // 
            this.ppPopular.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ppPopular.Appearance.Options.UseBackColor = true;
            this.ppPopular.Description = "Processing...";
            this.ppPopular.Location = new System.Drawing.Point(48, 20);
            this.ppPopular.Name = "ppPopular";
            this.ppPopular.Size = new System.Drawing.Size(246, 67);
            this.ppPopular.TabIndex = 1;
            this.ppPopular.Text = "progressPanel1";
            this.ppPopular.Visible = false;
            // 
            // lblRetweets
            // 
            this.lblRetweets.Appearance.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold);
            this.lblRetweets.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRetweets.Location = new System.Drawing.Point(6, 20);
            this.lblRetweets.Name = "lblRetweets";
            this.lblRetweets.Size = new System.Drawing.Size(321, 52);
            this.lblRetweets.TabIndex = 0;
            this.lblRetweets.Text = "labelControl1";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ppClassify);
            this.groupBox3.Controls.Add(this.lblClassify);
            this.groupBox3.Location = new System.Drawing.Point(7, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(647, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Classification";
            // 
            // ppClassify
            // 
            this.ppClassify.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ppClassify.Appearance.Options.UseBackColor = true;
            this.ppClassify.Description = "Processing...";
            this.ppClassify.Location = new System.Drawing.Point(192, 17);
            this.ppClassify.Name = "ppClassify";
            this.ppClassify.Size = new System.Drawing.Size(246, 67);
            this.ppClassify.TabIndex = 1;
            this.ppClassify.Text = "progressPanel1";
            this.ppClassify.Visible = false;
            // 
            // lblClassify
            // 
            this.lblClassify.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassify.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblClassify.Location = new System.Drawing.Point(142, 20);
            this.lblClassify.Name = "lblClassify";
            this.lblClassify.Size = new System.Drawing.Size(375, 52);
            this.lblClassify.TabIndex = 0;
            this.lblClassify.Text = "labelControl1";
            // 
            // bgwGetTweets
            // 
            this.bgwGetTweets.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGetTweets_DoWork);
            this.bgwGetTweets.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGetTweets_RunWorkerCompleted);
            // 
            // bgwEvaPopularity
            // 
            this.bgwEvaPopularity.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEvaPopularity_DoWork);
            this.bgwEvaPopularity.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwEvaPopularity_RunWorkerCompleted);
            // 
            // bgwAnthorAna
            // 
            this.bgwAnthorAna.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwAnthorAna_DoWork);
            this.bgwAnthorAna.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwAnthorAna_RunWorkerCompleted);
            // 
            // bgwSourceAna
            // 
            this.bgwSourceAna.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSourceAna_DoWork);
            this.bgwSourceAna.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwSourceAna_RunWorkerCompleted);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblEmotion);
            this.groupBox9.Location = new System.Drawing.Point(7, 234);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(333, 124);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Comment Emotion";
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.lblConAna);
            this.groupBox10.Location = new System.Drawing.Point(346, 234);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(308, 124);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Content Analysis";
            // 
            // lblEmotion
            // 
            this.lblEmotion.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmotion.Location = new System.Drawing.Point(29, 41);
            this.lblEmotion.Name = "lblEmotion";
            this.lblEmotion.Size = new System.Drawing.Size(160, 29);
            this.lblEmotion.TabIndex = 0;
            this.lblEmotion.Text = "labelControl1";
            this.lblEmotion.Visible = false;
            // 
            // lblConAna
            // 
            this.lblConAna.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConAna.Location = new System.Drawing.Point(27, 41);
            this.lblConAna.Name = "lblConAna";
            this.lblConAna.Size = new System.Drawing.Size(160, 29);
            this.lblConAna.TabIndex = 0;
            this.lblConAna.Text = "labelControl1";
            this.lblConAna.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fake News Detector";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTweets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl grdTweets;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblRefPageScore;
        private DevExpress.XtraEditors.LabelControl lblSatireScore;
        private DevExpress.XtraEditors.LabelControl lblSources;
        private DevExpress.XtraEditors.LabelControl lblAuthorAna;
        private DevExpress.XtraEditors.LabelControl lblRetweets;
        private DevExpress.XtraEditors.LabelControl lblClassify;
        private System.ComponentModel.BackgroundWorker bgwGetTweets;
        private DevExpress.XtraWaitForm.ProgressPanel ppRefPageScore;
        private DevExpress.XtraWaitForm.ProgressPanel ppSatireScore;
        private DevExpress.XtraWaitForm.ProgressPanel ppSources;
        private DevExpress.XtraWaitForm.ProgressPanel ppAuthorAna;
        private DevExpress.XtraWaitForm.ProgressPanel ppPopular;
        private DevExpress.XtraWaitForm.ProgressPanel ppClassify;
        private System.ComponentModel.BackgroundWorker bgwEvaPopularity;
        private System.ComponentModel.BackgroundWorker bgwAnthorAna;
        private System.ComponentModel.BackgroundWorker bgwSourceAna;
        private System.ComponentModel.BackgroundWorker bgwRefPageAna;
        private System.Windows.Forms.GroupBox groupBox10;
        private DevExpress.XtraEditors.LabelControl lblConAna;
        private System.Windows.Forms.GroupBox groupBox9;
        private DevExpress.XtraEditors.LabelControl lblEmotion;

    }
}

