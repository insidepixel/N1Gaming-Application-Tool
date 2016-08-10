namespace N1Gaming_Application_Tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpApplications = new System.Windows.Forms.TabPage();
            this.tbFeedbackContent = new System.Windows.Forms.RichTextBox();
            this.tbFeedbackTitle = new System.Windows.Forms.RichTextBox();
            this.tbDeclined = new System.Windows.Forms.RichTextBox();
            this.tbTrial = new System.Windows.Forms.RichTextBox();
            this.tbAccepted = new System.Windows.Forms.RichTextBox();
            this.cbDeclined = new System.Windows.Forms.ComboBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeclined = new System.Windows.Forms.Label();
            this.lblAccepted = new System.Windows.Forms.Label();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.lblAppLink = new System.Windows.Forms.Label();
            this.tbApplicationLink = new System.Windows.Forms.TextBox();
            this.lblTSID = new System.Windows.Forms.Label();
            this.tbTSID = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tpInterviews = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbInterviewGeneric = new System.Windows.Forms.TextBox();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.tbInterviewSpecific = new System.Windows.Forms.TextBox();
            this.cbInterview = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tpApplications.SuspendLayout();
            this.gbUserInfo.SuspendLayout();
            this.tpInterviews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpApplications);
            this.tabControl1.Controls.Add(this.tpInterviews);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tpApplications
            // 
            this.tpApplications.Controls.Add(this.tbFeedbackContent);
            this.tpApplications.Controls.Add(this.tbFeedbackTitle);
            this.tpApplications.Controls.Add(this.tbDeclined);
            this.tpApplications.Controls.Add(this.tbTrial);
            this.tpApplications.Controls.Add(this.tbAccepted);
            this.tpApplications.Controls.Add(this.cbDeclined);
            this.tpApplications.Controls.Add(this.lblFeedback);
            this.tpApplications.Controls.Add(this.label1);
            this.tpApplications.Controls.Add(this.lblDeclined);
            this.tpApplications.Controls.Add(this.lblAccepted);
            this.tpApplications.Controls.Add(this.gbUserInfo);
            this.tpApplications.Location = new System.Drawing.Point(4, 22);
            this.tpApplications.Name = "tpApplications";
            this.tpApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplications.Size = new System.Drawing.Size(710, 423);
            this.tpApplications.TabIndex = 0;
            this.tpApplications.Text = "Applications";
            this.tpApplications.UseVisualStyleBackColor = true;
            // 
            // tbFeedbackContent
            // 
            this.tbFeedbackContent.BackColor = System.Drawing.SystemColors.Window;
            this.tbFeedbackContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFeedbackContent.Location = new System.Drawing.Point(361, 325);
            this.tbFeedbackContent.Name = "tbFeedbackContent";
            this.tbFeedbackContent.ReadOnly = true;
            this.tbFeedbackContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbFeedbackContent.Size = new System.Drawing.Size(342, 92);
            this.tbFeedbackContent.TabIndex = 15;
            this.tbFeedbackContent.Text = "";
            this.tbFeedbackContent.MouseEnter += new System.EventHandler(this.tbMouseEnter);
            // 
            // tbFeedbackTitle
            // 
            this.tbFeedbackTitle.BackColor = System.Drawing.SystemColors.Window;
            this.tbFeedbackTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFeedbackTitle.Location = new System.Drawing.Point(361, 299);
            this.tbFeedbackTitle.Multiline = false;
            this.tbFeedbackTitle.Name = "tbFeedbackTitle";
            this.tbFeedbackTitle.ReadOnly = true;
            this.tbFeedbackTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbFeedbackTitle.Size = new System.Drawing.Size(341, 20);
            this.tbFeedbackTitle.TabIndex = 14;
            this.tbFeedbackTitle.Text = "";
            this.tbFeedbackTitle.MouseEnter += new System.EventHandler(this.tbMouseEnter);
            // 
            // tbDeclined
            // 
            this.tbDeclined.BackColor = System.Drawing.SystemColors.Window;
            this.tbDeclined.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeclined.Location = new System.Drawing.Point(8, 299);
            this.tbDeclined.Name = "tbDeclined";
            this.tbDeclined.ReadOnly = true;
            this.tbDeclined.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbDeclined.Size = new System.Drawing.Size(341, 118);
            this.tbDeclined.TabIndex = 13;
            this.tbDeclined.Text = "";
            this.tbDeclined.MouseEnter += new System.EventHandler(this.tbMouseEnter);
            // 
            // tbTrial
            // 
            this.tbTrial.BackColor = System.Drawing.SystemColors.Window;
            this.tbTrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTrial.Location = new System.Drawing.Point(362, 135);
            this.tbTrial.Name = "tbTrial";
            this.tbTrial.ReadOnly = true;
            this.tbTrial.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbTrial.Size = new System.Drawing.Size(341, 127);
            this.tbTrial.TabIndex = 12;
            this.tbTrial.Text = "";
            this.tbTrial.MouseEnter += new System.EventHandler(this.tbMouseEnter);
            // 
            // tbAccepted
            // 
            this.tbAccepted.BackColor = System.Drawing.SystemColors.Window;
            this.tbAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccepted.Location = new System.Drawing.Point(6, 135);
            this.tbAccepted.Name = "tbAccepted";
            this.tbAccepted.ReadOnly = true;
            this.tbAccepted.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbAccepted.Size = new System.Drawing.Size(341, 127);
            this.tbAccepted.TabIndex = 11;
            this.tbAccepted.Text = "";
            this.tbAccepted.MouseEnter += new System.EventHandler(this.tbMouseEnter);
            // 
            // cbDeclined
            // 
            this.cbDeclined.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeclined.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDeclined.FormattingEnabled = true;
            this.cbDeclined.Items.AddRange(new object[] {
            "Underage",
            "Banned",
            "Inappropriate Name"});
            this.cbDeclined.Location = new System.Drawing.Point(146, 274);
            this.cbDeclined.Name = "cbDeclined";
            this.cbDeclined.Size = new System.Drawing.Size(146, 24);
            this.cbDeclined.TabIndex = 4;
            this.cbDeclined.SelectedIndexChanged += new System.EventHandler(this.cbDeclined_SelectedIndexChanged);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(358, 277);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(108, 16);
            this.lblFeedback.TabIndex = 9;
            this.lblFeedback.Text = "Feedback Topic";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Trial started";
            // 
            // lblDeclined
            // 
            this.lblDeclined.AutoSize = true;
            this.lblDeclined.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeclined.Location = new System.Drawing.Point(8, 277);
            this.lblDeclined.Name = "lblDeclined";
            this.lblDeclined.Size = new System.Drawing.Size(132, 16);
            this.lblDeclined.TabIndex = 3;
            this.lblDeclined.Text = "Application Declined";
            // 
            // lblAccepted
            // 
            this.lblAccepted.AutoSize = true;
            this.lblAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccepted.Location = new System.Drawing.Point(8, 116);
            this.lblAccepted.Name = "lblAccepted";
            this.lblAccepted.Size = new System.Drawing.Size(136, 16);
            this.lblAccepted.TabIndex = 2;
            this.lblAccepted.Text = "Application Accepted";
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.lblAppLink);
            this.gbUserInfo.Controls.Add(this.tbApplicationLink);
            this.gbUserInfo.Controls.Add(this.lblTSID);
            this.gbUserInfo.Controls.Add(this.tbTSID);
            this.gbUserInfo.Controls.Add(this.lblUsername);
            this.gbUserInfo.Controls.Add(this.tbUsername);
            this.gbUserInfo.Location = new System.Drawing.Point(8, 6);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(223, 97);
            this.gbUserInfo.TabIndex = 0;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "User Info";
            // 
            // lblAppLink
            // 
            this.lblAppLink.AutoSize = true;
            this.lblAppLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppLink.Location = new System.Drawing.Point(6, 68);
            this.lblAppLink.Name = "lblAppLink";
            this.lblAppLink.Size = new System.Drawing.Size(102, 16);
            this.lblAppLink.TabIndex = 5;
            this.lblAppLink.Text = "Application Link";
            // 
            // tbApplicationLink
            // 
            this.tbApplicationLink.Location = new System.Drawing.Point(114, 67);
            this.tbApplicationLink.Name = "tbApplicationLink";
            this.tbApplicationLink.Size = new System.Drawing.Size(100, 20);
            this.tbApplicationLink.TabIndex = 4;
            this.tbApplicationLink.TextChanged += new System.EventHandler(this.tbApplicationLink_TextChanged);
            // 
            // lblTSID
            // 
            this.lblTSID.AutoSize = true;
            this.lblTSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSID.Location = new System.Drawing.Point(6, 42);
            this.lblTSID.Name = "lblTSID";
            this.lblTSID.Size = new System.Drawing.Size(98, 16);
            this.lblTSID.TabIndex = 3;
            this.lblTSID.Text = "Teamspeak ID";
            // 
            // tbTSID
            // 
            this.tbTSID.Location = new System.Drawing.Point(114, 41);
            this.tbTSID.Name = "tbTSID";
            this.tbTSID.Size = new System.Drawing.Size(100, 20);
            this.tbTSID.TabIndex = 2;
            this.tbTSID.TextChanged += new System.EventHandler(this.tbTSID_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(6, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 16);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(114, 15);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // tpInterviews
            // 
            this.tpInterviews.Controls.Add(this.splitContainer1);
            this.tpInterviews.Location = new System.Drawing.Point(4, 22);
            this.tpInterviews.Name = "tpInterviews";
            this.tpInterviews.Padding = new System.Windows.Forms.Padding(3);
            this.tpInterviews.Size = new System.Drawing.Size(710, 423);
            this.tpInterviews.TabIndex = 1;
            this.tpInterviews.Text = "Interviews";
            this.tpInterviews.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbInterviewGeneric);
            this.splitContainer1.Panel1.Controls.Add(this.lblGeneral);
            this.splitContainer1.Panel1MinSize = 175;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbInterviewSpecific);
            this.splitContainer1.Panel2.Controls.Add(this.cbInterview);
            this.splitContainer1.Panel2.Controls.Add(this.lblSection);
            this.splitContainer1.Panel2MinSize = 264;
            this.splitContainer1.Size = new System.Drawing.Size(700, 414);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 8;
            // 
            // tbInterviewGeneric
            // 
            this.tbInterviewGeneric.BackColor = System.Drawing.SystemColors.Window;
            this.tbInterviewGeneric.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbInterviewGeneric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInterviewGeneric.Location = new System.Drawing.Point(0, 33);
            this.tbInterviewGeneric.Multiline = true;
            this.tbInterviewGeneric.Name = "tbInterviewGeneric";
            this.tbInterviewGeneric.ReadOnly = true;
            this.tbInterviewGeneric.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInterviewGeneric.Size = new System.Drawing.Size(350, 381);
            this.tbInterviewGeneric.TabIndex = 0;
            this.tbInterviewGeneric.Text = resources.GetString("tbInterviewGeneric.Text");
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneral.Location = new System.Drawing.Point(2, 6);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(156, 16);
            this.lblGeneral.TabIndex = 1;
            this.lblGeneral.Text = "General Application Tips";
            // 
            // tbInterviewSpecific
            // 
            this.tbInterviewSpecific.BackColor = System.Drawing.SystemColors.Window;
            this.tbInterviewSpecific.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbInterviewSpecific.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInterviewSpecific.Location = new System.Drawing.Point(0, 33);
            this.tbInterviewSpecific.Multiline = true;
            this.tbInterviewSpecific.Name = "tbInterviewSpecific";
            this.tbInterviewSpecific.ReadOnly = true;
            this.tbInterviewSpecific.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInterviewSpecific.Size = new System.Drawing.Size(346, 381);
            this.tbInterviewSpecific.TabIndex = 1;
            this.tbInterviewSpecific.Text = "Section specific interview tips here";
            // 
            // cbInterview
            // 
            this.cbInterview.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInterview.FormattingEnabled = true;
            this.cbInterview.Items.AddRange(new object[] {
            "CS:GO",
            "LoL",
            "Rocket League",
            "ARMA3"});
            this.cbInterview.Location = new System.Drawing.Point(143, 3);
            this.cbInterview.Name = "cbInterview";
            this.cbInterview.Size = new System.Drawing.Size(121, 24);
            this.cbInterview.TabIndex = 4;
            this.cbInterview.SelectedIndexChanged += new System.EventHandler(this.cbInterview_SelectedIndexChanged);
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(3, 6);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(134, 16);
            this.lblSection.TabIndex = 5;
            this.lblSection.Text = "Section Specific Tips";
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(718, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.changelogToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.changelogToolStripMenuItem.Text = "Changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 473);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.Text = "N1Gaming Staff Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpApplications.ResumeLayout(false);
            this.tpApplications.PerformLayout();
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.tpInterviews.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpApplications;
        private System.Windows.Forms.TabPage tpInterviews;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.Label lblTSID;
        private System.Windows.Forms.TextBox tbTSID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblAppLink;
        private System.Windows.Forms.TextBox tbApplicationLink;
        private System.Windows.Forms.ComboBox cbDeclined;
        private System.Windows.Forms.Label lblDeclined;
        private System.Windows.Forms.Label lblAccepted;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox cbInterview;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbInterviewGeneric;
        private System.Windows.Forms.TextBox tbInterviewSpecific;
        private System.Windows.Forms.RichTextBox tbAccepted;
        private System.Windows.Forms.RichTextBox tbTrial;
        private System.Windows.Forms.RichTextBox tbFeedbackContent;
        private System.Windows.Forms.RichTextBox tbFeedbackTitle;
        private System.Windows.Forms.RichTextBox tbDeclined;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

