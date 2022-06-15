namespace NoteTakingUI
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CategoryFilterLabel = new System.Windows.Forms.Label();
			this.CategoryComboBox = new System.Windows.Forms.ComboBox();
			this.NotesListBox = new System.Windows.Forms.ListBox();
			this.NoteCreateDateTime = new System.Windows.Forms.DateTimePicker();
			this.NoteModifiedDateTime = new System.Windows.Forms.DateTimePicker();
			this.NoteTextRichTextBox = new System.Windows.Forms.RichTextBox();
			this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
			this.RemoveNoteButton = new System.Windows.Forms.Button();
			this.ChangeNoteButton = new System.Windows.Forms.Button();
			this.CreateNoteButton = new System.Windows.Forms.Button();
			this.NoteTitleLabel = new System.Windows.Forms.Label();
			this.NoteModifiedDateLabel = new System.Windows.Forms.Label();
			this.NoteCreateDateLabel = new System.Windows.Forms.Label();
			this.NoteCategoryLabel = new System.Windows.Forms.Label();
			this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
			this.MainSplitContainer.Panel1.SuspendLayout();
			this.MainSplitContainer.Panel2.SuspendLayout();
			this.MainSplitContainer.SuspendLayout();
			this.MainMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// CategoryFilterLabel
			// 
			this.CategoryFilterLabel.AutoSize = true;
			this.CategoryFilterLabel.Location = new System.Drawing.Point(3, 6);
			this.CategoryFilterLabel.Name = "CategoryFilterLabel";
			this.CategoryFilterLabel.Size = new System.Drawing.Size(109, 20);
			this.CategoryFilterLabel.TabIndex = 0;
			this.CategoryFilterLabel.Text = "Show Category";
			// 
			// CategoryComboBox
			// 
			this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CategoryComboBox.FormattingEnabled = true;
			this.CategoryComboBox.Location = new System.Drawing.Point(118, 3);
			this.CategoryComboBox.Name = "CategoryComboBox";
			this.CategoryComboBox.Size = new System.Drawing.Size(108, 28);
			this.CategoryComboBox.TabIndex = 1;
			// 
			// NotesListBox
			// 
			this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NotesListBox.FormattingEnabled = true;
			this.NotesListBox.ItemHeight = 20;
			this.NotesListBox.Location = new System.Drawing.Point(3, 37);
			this.NotesListBox.Name = "NotesListBox";
			this.NotesListBox.Size = new System.Drawing.Size(223, 304);
			this.NotesListBox.TabIndex = 2;
			this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
			// 
			// NoteCreateDateTime
			// 
			this.NoteCreateDateTime.Enabled = false;
			this.NoteCreateDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.NoteCreateDateTime.Location = new System.Drawing.Point(73, 60);
			this.NoteCreateDateTime.Name = "NoteCreateDateTime";
			this.NoteCreateDateTime.Size = new System.Drawing.Size(100, 27);
			this.NoteCreateDateTime.TabIndex = 3;
			// 
			// NoteModifiedDateTime
			// 
			this.NoteModifiedDateTime.Enabled = false;
			this.NoteModifiedDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.NoteModifiedDateTime.Location = new System.Drawing.Point(258, 60);
			this.NoteModifiedDateTime.Name = "NoteModifiedDateTime";
			this.NoteModifiedDateTime.Size = new System.Drawing.Size(104, 27);
			this.NoteModifiedDateTime.TabIndex = 4;
			// 
			// NoteTextRichTextBox
			// 
			this.NoteTextRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NoteTextRichTextBox.Enabled = false;
			this.NoteTextRichTextBox.Location = new System.Drawing.Point(3, 93);
			this.NoteTextRichTextBox.Name = "NoteTextRichTextBox";
			this.NoteTextRichTextBox.Size = new System.Drawing.Size(359, 294);
			this.NoteTextRichTextBox.TabIndex = 5;
			this.NoteTextRichTextBox.Text = "";
			// 
			// MainSplitContainer
			// 
			this.MainSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainSplitContainer.Location = new System.Drawing.Point(12, 31);
			this.MainSplitContainer.Name = "MainSplitContainer";
			// 
			// MainSplitContainer.Panel1
			// 
			this.MainSplitContainer.Panel1.Controls.Add(this.RemoveNoteButton);
			this.MainSplitContainer.Panel1.Controls.Add(this.ChangeNoteButton);
			this.MainSplitContainer.Panel1.Controls.Add(this.CreateNoteButton);
			this.MainSplitContainer.Panel1.Controls.Add(this.CategoryFilterLabel);
			this.MainSplitContainer.Panel1.Controls.Add(this.CategoryComboBox);
			this.MainSplitContainer.Panel1.Controls.Add(this.NotesListBox);
			this.MainSplitContainer.Panel1MinSize = 229;
			// 
			// MainSplitContainer.Panel2
			// 
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteTitleLabel);
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteTextRichTextBox);
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteModifiedDateLabel);
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteModifiedDateTime);
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteCreateDateLabel);
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteCategoryLabel);
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteCreateDateTime);
			this.MainSplitContainer.Panel2MinSize = 365;
			this.MainSplitContainer.Size = new System.Drawing.Size(598, 390);
			this.MainSplitContainer.SplitterDistance = 229;
			this.MainSplitContainer.TabIndex = 6;
			// 
			// RemoveNoteButton
			// 
			this.RemoveNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RemoveNoteButton.Location = new System.Drawing.Point(95, 347);
			this.RemoveNoteButton.Name = "RemoveNoteButton";
			this.RemoveNoteButton.Size = new System.Drawing.Size(40, 40);
			this.RemoveNoteButton.TabIndex = 5;
			this.RemoveNoteButton.Text = "-";
			this.RemoveNoteButton.UseVisualStyleBackColor = true;
			this.RemoveNoteButton.Click += new System.EventHandler(this.RemoveNoteButton_Click);
			// 
			// ChangeNoteButton
			// 
			this.ChangeNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ChangeNoteButton.Location = new System.Drawing.Point(49, 347);
			this.ChangeNoteButton.Name = "ChangeNoteButton";
			this.ChangeNoteButton.Size = new System.Drawing.Size(40, 40);
			this.ChangeNoteButton.TabIndex = 4;
			this.ChangeNoteButton.Text = "/";
			this.ChangeNoteButton.UseVisualStyleBackColor = true;
			this.ChangeNoteButton.Click += new System.EventHandler(this.ChangeNoteButton_Click);
			// 
			// CreateNoteButton
			// 
			this.CreateNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CreateNoteButton.Location = new System.Drawing.Point(3, 347);
			this.CreateNoteButton.Name = "CreateNoteButton";
			this.CreateNoteButton.Size = new System.Drawing.Size(40, 40);
			this.CreateNoteButton.TabIndex = 3;
			this.CreateNoteButton.Text = "+";
			this.CreateNoteButton.UseVisualStyleBackColor = true;
			this.CreateNoteButton.Click += new System.EventHandler(this.CreateNoteButton_Click);
			// 
			// NoteTitleLabel
			// 
			this.NoteTitleLabel.AutoSize = true;
			this.NoteTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.NoteTitleLabel.Location = new System.Drawing.Point(3, 3);
			this.NoteTitleLabel.Name = "NoteTitleLabel";
			this.NoteTitleLabel.Size = new System.Drawing.Size(104, 28);
			this.NoteTitleLabel.TabIndex = 6;
			this.NoteTitleLabel.Text = "Note title";
			// 
			// NoteModifiedDateLabel
			// 
			this.NoteModifiedDateLabel.AutoSize = true;
			this.NoteModifiedDateLabel.Location = new System.Drawing.Point(179, 65);
			this.NoteModifiedDateLabel.Name = "NoteModifiedDateLabel";
			this.NoteModifiedDateLabel.Size = new System.Drawing.Size(73, 20);
			this.NoteModifiedDateLabel.TabIndex = 5;
			this.NoteModifiedDateLabel.Text = "Modified:";
			// 
			// NoteCreateDateLabel
			// 
			this.NoteCreateDateLabel.AutoSize = true;
			this.NoteCreateDateLabel.Location = new System.Drawing.Point(3, 65);
			this.NoteCreateDateLabel.Name = "NoteCreateDateLabel";
			this.NoteCreateDateLabel.Size = new System.Drawing.Size(64, 20);
			this.NoteCreateDateLabel.TabIndex = 4;
			this.NoteCreateDateLabel.Text = "Created:";
			// 
			// NoteCategoryLabel
			// 
			this.NoteCategoryLabel.AutoSize = true;
			this.NoteCategoryLabel.Location = new System.Drawing.Point(3, 37);
			this.NoteCategoryLabel.Name = "NoteCategoryLabel";
			this.NoteCategoryLabel.Size = new System.Drawing.Size(76, 20);
			this.NoteCategoryLabel.TabIndex = 0;
			this.NoteCategoryLabel.Text = "Category: ";
			// 
			// MainMenuStrip
			// 
			this.MainMenuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
			this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MainMenuStrip.Name = "MainMenuStrip";
			this.MainMenuStrip.Size = new System.Drawing.Size(622, 28);
			this.MainMenuStrip.TabIndex = 7;
			this.MainMenuStrip.Text = "MainMenuStrip";
			// 
			// FileToolStripMenuItem
			// 
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.FileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// EditToolStripMenuItem
			// 
			this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteToolStripMenuItem,
            this.EditNoteToolStripMenuItem,
            this.DeleteNoteToolStripMenuItem});
			this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
			this.EditToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
			this.EditToolStripMenuItem.Text = "Edit";
			// 
			// AddNoteToolStripMenuItem
			// 
			this.AddNoteToolStripMenuItem.Name = "AddNoteToolStripMenuItem";
			this.AddNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
			this.AddNoteToolStripMenuItem.Text = "Add Note";
			this.AddNoteToolStripMenuItem.Click += new System.EventHandler(this.CreateNoteButton_Click);
			// 
			// EditNoteToolStripMenuItem
			// 
			this.EditNoteToolStripMenuItem.Name = "EditNoteToolStripMenuItem";
			this.EditNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
			this.EditNoteToolStripMenuItem.Text = "Edit Note";
			this.EditNoteToolStripMenuItem.Click += new System.EventHandler(this.ChangeNoteButton_Click);
			// 
			// DeleteNoteToolStripMenuItem
			// 
			this.DeleteNoteToolStripMenuItem.Name = "DeleteNoteToolStripMenuItem";
			this.DeleteNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
			this.DeleteNoteToolStripMenuItem.Text = "Remove Note";
			this.DeleteNoteToolStripMenuItem.Click += new System.EventHandler(this.RemoveNoteButton_Click);
			// 
			// HelpToolStripMenuItem
			// 
			this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
			this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
			this.HelpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
			this.HelpToolStripMenuItem.Text = "Help";
			// 
			// AboutToolStripMenuItem
			// 
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			this.AboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
			this.AboutToolStripMenuItem.Text = "About";
			this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(622, 433);
			this.Controls.Add(this.MainSplitContainer);
			this.Controls.Add(this.MainMenuStrip);
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Note Taking Application";
			this.MainSplitContainer.Panel1.ResumeLayout(false);
			this.MainSplitContainer.Panel1.PerformLayout();
			this.MainSplitContainer.Panel2.ResumeLayout(false);
			this.MainSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
			this.MainSplitContainer.ResumeLayout(false);
			this.MainMenuStrip.ResumeLayout(false);
			this.MainMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label CategoryFilterLabel;
		private ComboBox CategoryComboBox;
		private ListBox NotesListBox;
		private DateTimePicker NoteCreateDateTime;
		private DateTimePicker NoteModifiedDateTime;
		private RichTextBox NoteTextRichTextBox;
		private SplitContainer MainSplitContainer;
		private Label NoteCategoryLabel;
		private Label NoteModifiedDateLabel;
		private Label NoteCreateDateLabel;
		private Label NoteTitleLabel;
		private Button RemoveNoteButton;
		private Button ChangeNoteButton;
		private Button CreateNoteButton;
		private MenuStrip MainMenuStrip;
		private ToolStripMenuItem FileToolStripMenuItem;
		private ToolStripMenuItem EditToolStripMenuItem;
		private ToolStripMenuItem HelpToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem AddNoteToolStripMenuItem;
		private ToolStripMenuItem EditNoteToolStripMenuItem;
		private ToolStripMenuItem DeleteNoteToolStripMenuItem;
		private ToolStripMenuItem AboutToolStripMenuItem;
	}
}