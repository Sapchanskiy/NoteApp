namespace NoteAppUI
{
    partial class AboutForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.WebsiteLabel = new System.Windows.Forms.Label();
            this.FooterSignatureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(106, 25);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "NoteAPP";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(12, 34);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(43, 13);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "v. 1.0.0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(12, 76);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(123, 13);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author: Sergei Saprunov";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 113);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(152, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "e-mail: saprunov.so@micran.ru";
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // WebsiteLabel
            // 
            this.WebsiteLabel.AutoSize = true;
            this.WebsiteLabel.Location = new System.Drawing.Point(12, 135);
            this.WebsiteLabel.Name = "WebsiteLabel";
            this.WebsiteLabel.Size = new System.Drawing.Size(152, 13);
            this.WebsiteLabel.TabIndex = 4;
            this.WebsiteLabel.Text = "Github: Sapchanskiy/NoteApp";
            // 
            // FooterSignatureLabel
            // 
            this.FooterSignatureLabel.AutoSize = true;
            this.FooterSignatureLabel.Location = new System.Drawing.Point(12, 205);
            this.FooterSignatureLabel.Name = "FooterSignatureLabel";
            this.FooterSignatureLabel.Size = new System.Drawing.Size(125, 13);
            this.FooterSignatureLabel.TabIndex = 5;
            this.FooterSignatureLabel.Text = "2018 Sergei Saprunov ©";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 233);
            this.Controls.Add(this.FooterSignatureLabel);
            this.Controls.Add(this.WebsiteLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label WebsiteLabel;
        private System.Windows.Forms.Label FooterSignatureLabel;
    }
}