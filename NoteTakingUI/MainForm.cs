using NoteTaking;

namespace NoteTakingUI
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// Конструкторы.
		/// </summary>

		/// <summary>
		/// Конструктор формы по умолчанию.
		/// </summary>
		public MainForm()
		{
			InitializeComponent();

			_notes = new();
		}

		/// <summary>
		/// Ивенты.
		/// </summary>

		/// <summary>
		/// Отобразить информации о приложении.
		/// </summary>
		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm aboutForm = new();
			aboutForm.ShowDialog();
		}

		/// <summary>
		/// Создать новую заметку.
		/// </summary>
		private void CreateNoteButton_Click(object sender, EventArgs e)
		{
			Note newNote = new();
			NoteEditForm noteEditForm = new(newNote);
			DialogResult result = noteEditForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				_notes.AddNote(newNote);
				NotesListBox.Items.Add(newNote.Title);
				NotesListBox.SelectedIndex = _notes.NotesCount - 1;
			}
		}

		/// <summary>
		/// Редактировать выбранную заметку.
		/// </summary>
		private void ChangeNoteButton_Click(object sender, EventArgs e)
		{
			int selectedNoteIndex = NotesListBox.SelectedIndex;
			try
			{
				Note selectedNote = _notes[selectedNoteIndex];
				NoteEditForm noteEditForm = new(selectedNote);
				DialogResult result = noteEditForm.ShowDialog();
				if (result == DialogResult.OK)
				{
					NotesListBox.Items[selectedNoteIndex] = selectedNote.Title;
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error occured");
			}
		}

		/// <summary>
		/// Удалить выбранную заметку.
		/// </summary>
		private void RemoveNoteButton_Click(object sender, EventArgs e)
		{
			int selectedNoteIndex = NotesListBox.SelectedIndex;
			try
			{
				_notes.RemoveNote(selectedNoteIndex);
				NotesListBox.Items.RemoveAt(selectedNoteIndex);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error occured");
			}
		}

		/// <summary>
		/// Обновить содержимое выбранной заметки на экране.
		/// </summary>
		private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (NotesListBox.SelectedIndex != -1)
			{
				Note selectedNote = _notes[NotesListBox.SelectedIndex];
				NoteTitleLabel.Text = selectedNote.Title;
				NoteCategoryLabel.Text = string.Format("Category: {0}", selectedNote.Category);
				NoteTextRichTextBox.Text = selectedNote.Text;
				NoteCreateDateTime.Value = selectedNote.CreatingTime;
				NoteModifiedDateTime.Value = selectedNote.ModifiedTime;
			}
		}

		/// <summary>
		/// Реализация.
		/// </summary>

		/// <summary>
		/// Список заметок.
		/// </summary>
		private Notebook _notes;
	}
}