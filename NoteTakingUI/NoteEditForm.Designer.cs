namespace NoteTakingUI
{
	partial class NoteEditForm
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
			this.NoteTitleLabel = new System.Windows.Forms.Label();
			this.NoteTitleTextBox = new System.Windows.Forms.TextBox();
			this.NoteCategoryComboBox = new System.Windows.Forms.ComboBox();
			this.NoteCreateDateLabel = new System.Windows.Forms.Label();
			this.ModifiedDateLabel = new System.Windows.Forms.Label();
			this.NoteCreateDateTime = new System.Windows.Forms.DateTimePicker();
			this.NoteModifiedDateTime = new System.Windows.Forms.DateTimePicker();
			this.NoteCategoryLabel = new System.Windows.Forms.Label();
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
			this.NoteTitleLabel.Size = new System.Drawing.Size(41, 20);
			this.NoteTitleLabel.TabIndex = 0;
			this.NoteTitleLabel.Text = "Title:";
			// 
			// NoteTitleTextBox
			// 
			this.NoteTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NoteTitleTextBox.Location = new System.Drawing.Point(90, 12);
			this.NoteTitleTextBox.Name = "NoteTitleTextBox";
			this.NoteTitleTextBox.Size = new System.Drawing.Size(520, 27);
			this.NoteTitleTextBox.TabIndex = 1;
			// 
			// NoteCategoryComboBox
			// 
			this.NoteCategoryComboBox.FormattingEnabled = true;
			this.NoteCategoryComboBox.Location = new System.Drawing.Point(90, 45);
			this.NoteCategoryComboBox.Name = "NoteCategoryComboBox";
			this.NoteCategoryComboBox.Size = new System.Drawing.Size(151, 28);
			this.NoteCategoryComboBox.TabIndex = 3;
			// 
			// NoteCreateDateLabel
			// 
			this.NoteCreateDateLabel.AutoSize = true;
			this.NoteCreateDateLabel.Location = new System.Drawing.Point(12, 84);
			this.NoteCreateDateLabel.Name = "NoteCreateDateLabel";
			this.NoteCreateDateLabel.Size = new System.Drawing.Size(64, 20);
			this.NoteCreateDateLabel.TabIndex = 5;
			this.NoteCreateDateLabel.Text = "Created:";
			// 
			// ModifiedDateLabel
			// 
			this.ModifiedDateLabel.AutoSize = true;
			this.ModifiedDateLabel.Location = new System.Drawing.Point(196, 84);
			this.ModifiedDateLabel.Name = "ModifiedDateLabel";
			this.ModifiedDateLabel.Size = new System.Drawing.Size(73, 20);
			this.ModifiedDateLabel.TabIndex = 6;
			this.ModifiedDateLabel.Text = "Modified:";
			// 
			// NoteCreateDateTime
			// 
			this.NoteCreateDateTime.Enabled = false;
			this.NoteCreateDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.NoteCreateDateTime.Location = new System.Drawing.Point(90, 79);
			this.NoteCreateDateTime.Name = "NoteCreateDateTime";
			this.NoteCreateDateTime.Size = new System.Drawing.Size(100, 27);
			this.NoteCreateDateTime.TabIndex = 7;
			// 
			// NoteModifiedDateTime
			// 
			this.NoteModifiedDateTime.Enabled = false;
			this.NoteModifiedDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.NoteModifiedDateTime.Location = new System.Drawing.Point(275, 79);
			this.NoteModifiedDateTime.Name = "NoteModifiedDateTime";
			this.NoteModifiedDateTime.Size = new System.Drawing.Size(104, 27);
			this.NoteModifiedDateTime.TabIndex = 8;
			// 
			// NoteCategoryLabel
			// 
			this.NoteCategoryLabel.AutoSize = true;
			this.NoteCategoryLabel.Location = new System.Drawing.Point(12, 48);
			this.NoteCategoryLabel.Name = "NoteCategoryLabel";
			this.NoteCategoryLabel.Size = new System.Drawing.Size(72, 20);
			this.NoteCategoryLabel.TabIndex = 9;
			this.NoteCategoryLabel.Text = "Category:";
			// 
			// NoteTextRichTextBox
			// 
			this.NoteTextRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NoteTextRichTextBox.Location = new System.Drawing.Point(12, 112);
			this.NoteTextRichTextBox.Name = "NoteTextRichTextBox";
			this.NoteTextRichTextBox.Size = new System.Drawing.Size(598, 274);
			this.NoteTextRichTextBox.TabIndex = 10;
			this.NoteTextRichTextBox.Text = "";
			// 
			// OkButton
			// 
			this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OkButton.Location = new System.Drawing.Point(416, 392);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(94, 29);
			this.OkButton.TabIndex = 11;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			// 
			// CancelButton
			// 
			this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelButton.Location = new System.Drawing.Point(516, 392);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(94, 29);
			this.CancelButton.TabIndex = 12;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// NoteEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 433);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.NoteTextRichTextBox);
			this.Controls.Add(this.NoteCategoryLabel);
			this.Controls.Add(this.NoteModifiedDateTime);
			this.Controls.Add(this.NoteCreateDateTime);
			this.Controls.Add(this.ModifiedDateLabel);
			this.Controls.Add(this.NoteCreateDateLabel);
			this.Controls.Add(this.NoteCategoryComboBox);
			this.Controls.Add(this.NoteTitleTextBox);
			this.Controls.Add(this.NoteTitleLabel);
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "NoteEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Note";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label NoteTitleLabel;
		private TextBox NoteTitleTextBox;
		private ComboBox NoteCategoryComboBox;
		private Label NoteCreateDateLabel;
		private Label ModifiedDateLabel;
		private DateTimePicker NoteCreateDateTime;
		private DateTimePicker NoteModifiedDateTime;
		private Label NoteCategoryLabel;
		private RichTextBox NoteTextRichTextBox;
		private Button OkButton;
		private Button CancelButton;
	}
}