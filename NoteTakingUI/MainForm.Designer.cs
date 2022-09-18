namespace NoteTakingUI
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RemoveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
			this.RemoveNoteButton = new System.Windows.Forms.Button();
			this.EditNoteButton = new System.Windows.Forms.Button();
			this.CreateNoteButton = new System.Windows.Forms.Button();
			this.NotesListBox = new System.Windows.Forms.ListBox();
			this.CategoryComboBox = new System.Windows.Forms.ComboBox();
			this.CategoryFilterLabel = new System.Windows.Forms.Label();
			this.NoteTextRichTextBox = new System.Windows.Forms.RichTextBox();
			this.NoteModificationDateTime = new System.Windows.Forms.DateTimePicker();
			this.NoteModifiedDateLabel = new System.Windows.Forms.Label();
			this.NoteCreationDateTime = new System.Windows.Forms.DateTimePicker();
			this.NoteCreateDateLabel = new System.Windows.Forms.Label();
			this.NoteCategoryLabel = new System.Windows.Forms.Label();
			this.NoteTitleLabel = new System.Windows.Forms.Label();
			this.MainMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
			this.MainSplitContainer.Panel1.SuspendLayout();
			this.MainSplitContainer.Panel2.SuspendLayout();
			this.MainSplitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenuStrip
			// 
			this.MainMenuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
			this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MainMenuStrip.Name = "MainMenuStrip";
			this.MainMenuStrip.Size = new System.Drawing.Size(624, 24);
			this.MainMenuStrip.TabIndex = 0;
			this.MainMenuStrip.Text = "MainMenuStrip";
			// 
			// FileToolStripMenuItem
			// 
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.FileToolStripMenuItem.Text = "File";
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
			this.ExitToolStripMenuItem.Text = "Exit";
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// EditToolStripMenuItem
			// 
			this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteToolStripMenuItem,
            this.EditNoteToolStripMenuItem,
            this.RemoveNoteToolStripMenuItem});
			this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
			this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.EditToolStripMenuItem.Text = "Edit";
			// 
			// AddNoteToolStripMenuItem
			// 
			this.AddNoteToolStripMenuItem.Name = "AddNoteToolStripMenuItem";
			this.AddNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.AddNoteToolStripMenuItem.Text = "Add Note";
			this.AddNoteToolStripMenuItem.Click += new System.EventHandler(this.CreateNoteButton_Click);
			// 
			// EditNoteToolStripMenuItem
			// 
			this.EditNoteToolStripMenuItem.Name = "EditNoteToolStripMenuItem";
			this.EditNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.EditNoteToolStripMenuItem.Text = "Edit Note";
			this.EditNoteToolStripMenuItem.Click += new System.EventHandler(this.EditNoteButton_Click);
			// 
			// RemoveNoteToolStripMenuItem
			// 
			this.RemoveNoteToolStripMenuItem.Name = "RemoveNoteToolStripMenuItem";
			this.RemoveNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.RemoveNoteToolStripMenuItem.Text = "Remove Note";
			this.RemoveNoteToolStripMenuItem.Click += new System.EventHandler(this.RemoveNoteButton_Click);
			// 
			// HelpToolStripMenuItem
			// 
			this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
			this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
			this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.HelpToolStripMenuItem.Text = "Help";
			// 
			// AboutToolStripMenuItem
			// 
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			this.AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.AboutToolStripMenuItem.Text = "About";
			this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			// 
			// MainSplitContainer
			// 
			this.MainSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainSplitContainer.Location = new System.Drawing.Point(12, 27);
			this.MainSplitContainer.Name = "MainSplitContainer";
			// 
			// MainSplitContainer.Panel1
			// 
			this.MainSplitContainer.Panel1.Controls.Add(this.RemoveNoteButton);
			this.MainSplitContainer.Panel1.Controls.Add(this.EditNoteButton);
			this.MainSplitContainer.Panel1.Controls.Add(this.CreateNoteButton);
			this.MainSplitContainer.Panel1.Controls.Add(this.NotesListBox);
			this.MainSplitContainer.Panel1.Controls.Add(this.CategoryComboBox);
			this.MainSplitContainer.Panel1.Controls.Add(this.CategoryFilterLabel);
			this.MainSplitContainer.Panel1MinSize = 200;
			// 
			// MainSplitContainer.Panel2
			// 
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteTextRichTextBox);
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteModificationDateTime);
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteModifiedDateLabel);
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteCreationDateTime);
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteCreateDateLabel);
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteCategoryLabel);
			this.MainSplitContainer.Panel2.Controls.Add(this.NoteTitleLabel);
			this.MainSplitContainer.Panel2MinSize = 396;
			this.MainSplitContainer.Size = new System.Drawing.Size(600, 402);
			this.MainSplitContainer.SplitterDistance = 200;
			this.MainSplitContainer.TabIndex = 1;
			// 
			// RemoveNoteButton
			// 
			this.RemoveNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RemoveNoteButton.BackgroundImage = global::NoteTakingUI.Properties.Resources.DeleteNote;
			this.RemoveNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.RemoveNoteButton.Location = new System.Drawing.Point(99, 357);
			this.RemoveNoteButton.Name = "RemoveNoteButton";
			this.RemoveNoteButton.Size = new System.Drawing.Size(42, 42);
			this.RemoveNoteButton.TabIndex = 5;
			this.RemoveNoteButton.UseVisualStyleBackColor = true;
			this.RemoveNoteButton.Click += new System.EventHandler(this.RemoveNoteButton_Click);
			// 
			// EditNoteButton
			// 
			this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.EditNoteButton.BackgroundImage = global::NoteTakingUI.Properties.Resources.EditNote;
			this.EditNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.EditNoteButton.Location = new System.Drawing.Point(51, 357);
			this.EditNoteButton.Name = "EditNoteButton";
			this.EditNoteButton.Size = new System.Drawing.Size(42, 42);
			this.EditNoteButton.TabIndex = 4;
			this.EditNoteButton.UseVisualStyleBackColor = true;
			this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
			// 
			// CreateNoteButton
			// 
			this.CreateNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CreateNoteButton.BackgroundImage = global::NoteTakingUI.Properties.Resources.AddNote;
			this.CreateNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.CreateNoteButton.Location = new System.Drawing.Point(3, 357);
			this.CreateNoteButton.Name = "CreateNoteButton";
			this.CreateNoteButton.Size = new System.Drawing.Size(42, 42);
			this.CreateNoteButton.TabIndex = 3;
			this.CreateNoteButton.UseVisualStyleBackColor = true;
			this.CreateNoteButton.Click += new System.EventHandler(this.CreateNoteButton_Click);
			// 
			// NotesListBox
			// 
			this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NotesListBox.FormattingEnabled = true;
			this.NotesListBox.ItemHeight = 15;
			this.NotesListBox.Location = new System.Drawing.Point(0, 32);
			this.NotesListBox.Name = "NotesListBox";
			this.NotesListBox.Size = new System.Drawing.Size(197, 319);
			this.NotesListBox.TabIndex = 2;
			this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
			// 
			// CategoryComboBox
			// 
			this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CategoryComboBox.FormattingEnabled = true;
			this.CategoryComboBox.Location = new System.Drawing.Point(97, 3);
			this.CategoryComboBox.Name = "CategoryComboBox";
			this.CategoryComboBox.Size = new System.Drawing.Size(100, 23);
			this.CategoryComboBox.TabIndex = 1;
			this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
			// 
			// CategoryFilterLabel
			// 
			this.CategoryFilterLabel.AutoSize = true;
			this.CategoryFilterLabel.Location = new System.Drawing.Point(3, 6);
			this.CategoryFilterLabel.Name = "CategoryFilterLabel";
			this.CategoryFilterLabel.Size = new System.Drawing.Size(90, 15);
			this.CategoryFilterLabel.TabIndex = 0;
			this.CategoryFilterLabel.Text = "Show Category:";
			// 
			// NoteTextRichTextBox
			// 
			this.NoteTextRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NoteTextRichTextBox.Location = new System.Drawing.Point(3, 79);
			this.NoteTextRichTextBox.Name = "NoteTextRichTextBox";
			this.NoteTextRichTextBox.ReadOnly = true;
			this.NoteTextRichTextBox.Size = new System.Drawing.Size(390, 320);
			this.NoteTextRichTextBox.TabIndex = 6;
			this.NoteTextRichTextBox.Text = "";
			// 
			// NoteModificationDateTime
			// 
			this.NoteModificationDateTime.Enabled = false;
			this.NoteModificationDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.NoteModificationDateTime.Location = new System.Drawing.Point(220, 50);
			this.NoteModificationDateTime.Name = "NoteModificationDateTime";
			this.NoteModificationDateTime.Size = new System.Drawing.Size(90, 23);
			this.NoteModificationDateTime.TabIndex = 5;
			// 
			// NoteModifiedDateLabel
			// 
			this.NoteModifiedDateLabel.AutoSize = true;
			this.NoteModifiedDateLabel.Location = new System.Drawing.Point(156, 56);
			this.NoteModifiedDateLabel.Name = "NoteModifiedDateLabel";
			this.NoteModifiedDateLabel.Size = new System.Drawing.Size(58, 15);
			this.NoteModifiedDateLabel.TabIndex = 4;
			this.NoteModifiedDateLabel.Text = "Modified:";
			// 
			// NoteCreationDateTime
			// 
			this.NoteCreationDateTime.Enabled = false;
			this.NoteCreationDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.NoteCreationDateTime.Location = new System.Drawing.Point(60, 50);
			this.NoteCreationDateTime.Name = "NoteCreationDateTime";
			this.NoteCreationDateTime.Size = new System.Drawing.Size(90, 23);
			this.NoteCreationDateTime.TabIndex = 3;
			// 
			// NoteCreateDateLabel
			// 
			this.NoteCreateDateLabel.AutoSize = true;
			this.NoteCreateDateLabel.Location = new System.Drawing.Point(3, 56);
			this.NoteCreateDateLabel.Name = "NoteCreateDateLabel";
			this.NoteCreateDateLabel.Size = new System.Drawing.Size(51, 15);
			this.NoteCreateDateLabel.TabIndex = 2;
			this.NoteCreateDateLabel.Text = "Created:";
			// 
			// NoteCategoryLabel
			// 
			this.NoteCategoryLabel.AutoSize = true;
			this.NoteCategoryLabel.Location = new System.Drawing.Point(3, 32);
			this.NoteCategoryLabel.Name = "NoteCategoryLabel";
			this.NoteCategoryLabel.Size = new System.Drawing.Size(61, 15);
			this.NoteCategoryLabel.TabIndex = 1;
			this.NoteCategoryLabel.Text = "Category: ";
			// 
			// NoteTitleLabel
			// 
			this.NoteTitleLabel.AutoSize = true;
			this.NoteTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.NoteTitleLabel.Location = new System.Drawing.Point(3, 6);
			this.NoteTitleLabel.Name = "NoteTitleLabel";
			this.NoteTitleLabel.Size = new System.Drawing.Size(83, 21);
			this.NoteTitleLabel.TabIndex = 0;
			this.NoteTitleLabel.Text = "Note title";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(624, 441);
			this.Controls.Add(this.MainSplitContainer);
			this.Controls.Add(this.MainMenuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Note Taking Application";
			this.MainMenuStrip.ResumeLayout(false);
			this.MainMenuStrip.PerformLayout();
			this.MainSplitContainer.Panel1.ResumeLayout(false);
			this.MainSplitContainer.Panel1.PerformLayout();
			this.MainSplitContainer.Panel2.ResumeLayout(false);
			this.MainSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
			this.MainSplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip MainMenuStrip;
		private ToolStripMenuItem FileToolStripMenuItem;
		private ToolStripMenuItem EditToolStripMenuItem;
		private ToolStripMenuItem HelpToolStripMenuItem;
		private ToolStripMenuItem ExitToolStripMenuItem;
		private ToolStripMenuItem AddNoteToolStripMenuItem;
		private ToolStripMenuItem EditNoteToolStripMenuItem;
		private ToolStripMenuItem RemoveNoteToolStripMenuItem;
		private ToolStripMenuItem AboutToolStripMenuItem;
		private SplitContainer MainSplitContainer;
		private Label CategoryFilterLabel;
		private ComboBox CategoryComboBox;
		private ListBox NotesListBox;
		private Button RemoveNoteButton;
		private Button EditNoteButton;
		private Button CreateNoteButton;
		private Label NoteTitleLabel;
		private Label NoteCategoryLabel;
		private Label NoteCreateDateLabel;
		private DateTimePicker NoteCreationDateTime;
		private Label NoteModifiedDateLabel;
		private DateTimePicker NoteModificationDateTime;
		private RichTextBox NoteTextRichTextBox;
	}
}