namespace NoteTakingUI
{
	partial class NoteForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
			this.NoteTitleLabel = new System.Windows.Forms.Label();
			this.NoteTitleTextBox = new System.Windows.Forms.TextBox();
			this.NoteCategoryLabel = new System.Windows.Forms.Label();
			this.NoteCategoryComboBox = new System.Windows.Forms.ComboBox();
			this.NoteCreateDateLabel = new System.Windows.Forms.Label();
			this.NoteCreationDateTime = new System.Windows.Forms.DateTimePicker();
			this.ModifiedDateLabel = new System.Windows.Forms.Label();
			this.NoteModificationDateTime = new System.Windows.Forms.DateTimePicker();
			this.NoteTextRichTextBox = new System.Windows.Forms.RichTextBox();
			this.OkButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// NoteTitleLabel
			// 
			this.NoteTitleLabel.AutoSize = true;
			this.NoteTitleLabel.Location = new System.Drawing.Point(12, 15);
			this.NoteTitleLabel.Name = "NoteTitleLabel";
			this.NoteTitleLabel.Size = new System.Drawing.Size(32, 15);
			this.NoteTitleLabel.TabIndex = 0;
			this.NoteTitleLabel.Text = "Title:";
			// 
			// NoteTitleTextBox
			// 
			this.NoteTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NoteTitleTextBox.Location = new System.Drawing.Point(76, 12);
			this.NoteTitleTextBox.Name = "NoteTitleTextBox";
			this.NoteTitleTextBox.Size = new System.Drawing.Size(250, 23);
			this.NoteTitleTextBox.TabIndex = 1;
			// 
			// NoteCategoryLabel
			// 
			this.NoteCategoryLabel.AutoSize = true;
			this.NoteCategoryLabel.Location = new System.Drawing.Point(12, 44);
			this.NoteCategoryLabel.Name = "NoteCategoryLabel";
			this.NoteCategoryLabel.Size = new System.Drawing.Size(58, 15);
			this.NoteCategoryLabel.TabIndex = 2;
			this.NoteCategoryLabel.Text = "Category:";
			// 
			// NoteCategoryComboBox
			// 
			this.NoteCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.NoteCategoryComboBox.FormattingEnabled = true;
			this.NoteCategoryComboBox.Location = new System.Drawing.Point(76, 41);
			this.NoteCategoryComboBox.Name = "NoteCategoryComboBox";
			this.NoteCategoryComboBox.Size = new System.Drawing.Size(121, 23);
			this.NoteCategoryComboBox.TabIndex = 3;
			// 
			// NoteCreateDateLabel
			// 
			this.NoteCreateDateLabel.AutoSize = true;
			this.NoteCreateDateLabel.Location = new System.Drawing.Point(12, 76);
			this.NoteCreateDateLabel.Name = "NoteCreateDateLabel";
			this.NoteCreateDateLabel.Size = new System.Drawing.Size(51, 15);
			this.NoteCreateDateLabel.TabIndex = 4;
			this.NoteCreateDateLabel.Text = "Created:";
			// 
			// NoteCreationDateTime
			// 
			this.NoteCreationDateTime.Enabled = false;
			this.NoteCreationDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.NoteCreationDateTime.Location = new System.Drawing.Point(76, 70);
			this.NoteCreationDateTime.Name = "NoteCreationDateTime";
			this.NoteCreationDateTime.Size = new System.Drawing.Size(90, 23);
			this.NoteCreationDateTime.TabIndex = 5;
			// 
			// ModifiedDateLabel
			// 
			this.ModifiedDateLabel.AutoSize = true;
			this.ModifiedDateLabel.Location = new System.Drawing.Point(172, 76);
			this.ModifiedDateLabel.Name = "ModifiedDateLabel";
			this.ModifiedDateLabel.Size = new System.Drawing.Size(58, 15);
			this.ModifiedDateLabel.TabIndex = 6;
			this.ModifiedDateLabel.Text = "Modified:";
			// 
			// NoteModificationDateTime
			// 
			this.NoteModificationDateTime.Enabled = false;
			this.NoteModificationDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.NoteModificationDateTime.Location = new System.Drawing.Point(236, 70);
			this.NoteModificationDateTime.Name = "NoteModificationDateTime";
			this.NoteModificationDateTime.Size = new System.Drawing.Size(90, 23);
			this.NoteModificationDateTime.TabIndex = 7;
			// 
			// NoteTextRichTextBox
			// 
			this.NoteTextRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NoteTextRichTextBox.Location = new System.Drawing.Point(12, 99);
			this.NoteTextRichTextBox.Name = "NoteTextRichTextBox";
			this.NoteTextRichTextBox.Size = new System.Drawing.Size(440, 181);
			this.NoteTextRichTextBox.TabIndex = 8;
			this.NoteTextRichTextBox.Text = "";
			// 
			// OkButton
			// 
			this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OkButton.Location = new System.Drawing.Point(296, 286);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 9;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelButton.Location = new System.Drawing.Point(377, 286);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 10;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// NoteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 321);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.NoteTextRichTextBox);
			this.Controls.Add(this.NoteModificationDateTime);
			this.Controls.Add(this.ModifiedDateLabel);
			this.Controls.Add(this.NoteCreationDateTime);
			this.Controls.Add(this.NoteCreateDateLabel);
			this.Controls.Add(this.NoteCategoryComboBox);
			this.Controls.Add(this.NoteCategoryLabel);
			this.Controls.Add(this.NoteTitleTextBox);
			this.Controls.Add(this.NoteTitleLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(480, 360);
			this.Name = "NoteForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Note";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label NoteTitleLabel;
		private TextBox NoteTitleTextBox;
		private Label NoteCategoryLabel;
		private ComboBox NoteCategoryComboBox;
		private Label NoteCreateDateLabel;
		private DateTimePicker NoteCreationDateTime;
		private Label ModifiedDateLabel;
		private DateTimePicker NoteModificationDateTime;
		private RichTextBox NoteTextRichTextBox;
		private Button OkButton;
		private Button CancelButton;
	}
}