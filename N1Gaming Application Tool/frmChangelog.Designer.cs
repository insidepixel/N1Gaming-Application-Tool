namespace N1Gaming_Application_Tool
{
    partial class frmChangelog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangelog));
            this.tbChangelog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbChangelog
            // 
            this.tbChangelog.BackColor = System.Drawing.SystemColors.Window;
            this.tbChangelog.CausesValidation = false;
            this.tbChangelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChangelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChangelog.Location = new System.Drawing.Point(0, 0);
            this.tbChangelog.Multiline = true;
            this.tbChangelog.Name = "tbChangelog";
            this.tbChangelog.ReadOnly = true;
            this.tbChangelog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbChangelog.Size = new System.Drawing.Size(373, 261);
            this.tbChangelog.TabIndex = 0;
            this.tbChangelog.TabStop = false;
            this.tbChangelog.Text = resources.GetString("tbChangelog.Text");
            // 
            // frmChangelog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 261);
            this.Controls.Add(this.tbChangelog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangelog";
            this.Text = "Changelog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbChangelog;
    }
}