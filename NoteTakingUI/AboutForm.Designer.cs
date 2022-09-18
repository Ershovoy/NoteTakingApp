namespace NoteTakingUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.AppTitleLabel = new System.Windows.Forms.Label();
			this.AppVersionLabel = new System.Windows.Forms.Label();
			this.AppAuthorLabel = new System.Windows.Forms.Label();
			this.GitHubLabel = new System.Windows.Forms.Label();
			this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
			this.CopyrightLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// AppTitleLabel
			// 
			this.AppTitleLabel.AutoSize = true;
			this.AppTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.AppTitleLabel.Location = new System.Drawing.Point(12, 9);
			this.AppTitleLabel.Name = "AppTitleLabel";
			this.AppTitleLabel.Size = new System.Drawing.Size(196, 21);
			this.AppTitleLabel.TabIndex = 0;
			this.AppTitleLabel.Text = "Note Taking Application";
			// 
			// AppVersionLabel
			// 
			this.AppVersionLabel.AutoSize = true;
			this.AppVersionLabel.Location = new System.Drawing.Point(12, 30);
			this.AppVersionLabel.Name = "AppVersionLabel";
			this.AppVersionLabel.Size = new System.Drawing.Size(37, 15);
			this.AppVersionLabel.TabIndex = 1;
			this.AppVersionLabel.Text = "v0.3.0";
			// 
			// AppAuthorLabel
			// 
			this.AppAuthorLabel.AutoSize = true;
			this.AppAuthorLabel.Location = new System.Drawing.Point(12, 82);
			this.AppAuthorLabel.Name = "AppAuthorLabel";
			this.AppAuthorLabel.Size = new System.Drawing.Size(106, 15);
			this.AppAuthorLabel.TabIndex = 2;
			this.AppAuthorLabel.Text = "Author: Ilya Ershov";
			// 
			// GitHubLabel
			// 
			this.GitHubLabel.AutoSize = true;
			this.GitHubLabel.Location = new System.Drawing.Point(12, 97);
			this.GitHubLabel.Name = "GitHubLabel";
			this.GitHubLabel.Size = new System.Drawing.Size(48, 15);
			this.GitHubLabel.TabIndex = 3;
			this.GitHubLabel.Text = "GitHub:";
			// 
			// GitHubLinkLabel
			// 
			this.GitHubLinkLabel.AutoSize = true;
			this.GitHubLinkLabel.Location = new System.Drawing.Point(66, 97);
			this.GitHubLinkLabel.Name = "GitHubLinkLabel";
			this.GitHubLinkLabel.Size = new System.Drawing.Size(142, 15);
			this.GitHubLinkLabel.TabIndex = 4;
			this.GitHubLinkLabel.TabStop = true;
			this.GitHubLinkLabel.Text = "Ershovoy/NoteTakingApp";
			this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
			// 
			// CopyrightLabel
			// 
			this.CopyrightLabel.AutoSize = true;
			this.CopyrightLabel.Location = new System.Drawing.Point(261, 177);
			this.CopyrightLabel.Name = "CopyrightLabel";
			this.CopyrightLabel.Size = new System.Drawing.Size(31, 15);
			this.CopyrightLabel.TabIndex = 5;
			this.CopyrightLabel.Text = "2022";
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 201);
			this.Controls.Add(this.CopyrightLabel);
			this.Controls.Add(this.GitHubLinkLabel);
			this.Controls.Add(this.GitHubLabel);
			this.Controls.Add(this.AppAuthorLabel);
			this.Controls.Add(this.AppVersionLabel);
			this.Controls.Add(this.AppTitleLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
		private Label GitHubLabel;
		private LinkLabel GitHubLinkLabel;
		private Label CopyrightLabel;
	}
}