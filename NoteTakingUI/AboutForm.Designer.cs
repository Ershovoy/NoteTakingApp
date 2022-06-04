namespace NoteTakingAppUI
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
			this.AppTitleLabel = new System.Windows.Forms.Label();
			this.AppVersionLabel = new System.Windows.Forms.Label();
			this.AppAuthorLabel = new System.Windows.Forms.Label();
			this.CopyrightLabel = new System.Windows.Forms.Label();
			this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
			this.GitHubLabel = new System.Windows.Forms.Label();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.EmailLinkLabel = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// AppTitleLabel
			// 
			this.AppTitleLabel.AutoSize = true;
			this.AppTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.AppTitleLabel.Location = new System.Drawing.Point(12, 9);
			this.AppTitleLabel.Name = "AppTitleLabel";
			this.AppTitleLabel.Size = new System.Drawing.Size(242, 28);
			this.AppTitleLabel.TabIndex = 7;
			this.AppTitleLabel.Text = "Note Taking Application";
			// 
			// AppVersionLabel
			// 
			this.AppVersionLabel.AutoSize = true;
			this.AppVersionLabel.Location = new System.Drawing.Point(12, 37);
			this.AppVersionLabel.Name = "AppVersionLabel";
			this.AppVersionLabel.Size = new System.Drawing.Size(46, 20);
			this.AppVersionLabel.TabIndex = 8;
			this.AppVersionLabel.Text = "v0.0.1";
			// 
			// AppAuthorLabel
			// 
			this.AppAuthorLabel.AutoSize = true;
			this.AppAuthorLabel.Location = new System.Drawing.Point(12, 96);
			this.AppAuthorLabel.Name = "AppAuthorLabel";
			this.AppAuthorLabel.Size = new System.Drawing.Size(131, 20);
			this.AppAuthorLabel.TabIndex = 9;
			this.AppAuthorLabel.Text = "Author: Ilya Ershov";
			// 
			// CopyrightLabel
			// 
			this.CopyrightLabel.AutoSize = true;
			this.CopyrightLabel.Location = new System.Drawing.Point(249, 164);
			this.CopyrightLabel.Name = "CopyrightLabel";
			this.CopyrightLabel.Size = new System.Drawing.Size(41, 20);
			this.CopyrightLabel.TabIndex = 10;
			this.CopyrightLabel.Text = "2022";
			// 
			// GitHubLinkLabel
			// 
			this.GitHubLinkLabel.AutoSize = true;
			this.GitHubLinkLabel.Location = new System.Drawing.Point(74, 116);
			this.GitHubLinkLabel.Name = "GitHubLinkLabel";
			this.GitHubLinkLabel.Size = new System.Drawing.Size(177, 20);
			this.GitHubLinkLabel.TabIndex = 11;
			this.GitHubLinkLabel.TabStop = true;
			this.GitHubLinkLabel.Tag = "";
			this.GitHubLinkLabel.Text = "Ershovoy/NoteTakingApp";
			// 
			// GitHubLabel
			// 
			this.GitHubLabel.AutoSize = true;
			this.GitHubLabel.Location = new System.Drawing.Point(12, 116);
			this.GitHubLabel.Name = "GitHubLabel";
			this.GitHubLabel.Size = new System.Drawing.Size(59, 20);
			this.GitHubLabel.TabIndex = 12;
			this.GitHubLabel.Text = "GitHub:";
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(12, 136);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(49, 20);
			this.EmailLabel.TabIndex = 13;
			this.EmailLabel.Text = "Email:";
			// 
			// EmailLinkLabel
			// 
			this.EmailLinkLabel.AutoSize = true;
			this.EmailLinkLabel.Location = new System.Drawing.Point(67, 136);
			this.EmailLinkLabel.Name = "EmailLinkLabel";
			this.EmailLinkLabel.Size = new System.Drawing.Size(176, 20);
			this.EmailLinkLabel.TabIndex = 14;
			this.EmailLinkLabel.TabStop = true;
			this.EmailLinkLabel.Text = "ershov64372@gmail.com";
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(302, 193);
			this.Controls.Add(this.EmailLinkLabel);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.GitHubLabel);
			this.Controls.Add(this.GitHubLinkLabel);
			this.Controls.Add(this.CopyrightLabel);
			this.Controls.Add(this.AppAuthorLabel);
			this.Controls.Add(this.AppVersionLabel);
			this.Controls.Add(this.AppTitleLabel);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(320, 240);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(320, 240);
			this.Name = "AboutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label AppTitleLabel;
		private Label AppVersionLabel;
		private Label AppAuthorLabel;
		private Label CopyrightLabel;
		private LinkLabel GitHubLinkLabel;
		private Label GitHubLabel;
		private Label EmailLabel;
		private LinkLabel EmailLinkLabel;
	}
}