using NoteTaking;

namespace NoteTakingUI;

public partial class MainForm : Form
{
	/// <summary>
	/// Список заметок.
	/// </summary>
	private Notebook _notebookData;

	/// <summary>
	/// Список заметок для отображения на экране.
	/// </summary>
	private Notebook _displayedNotebook;

	/// <summary>
	/// Конструктор формы по умолчанию.
	/// </summary>
	public MainForm()
	{
		InitializeComponent();

		_displayedNotebook = new Notebook();

		try
		{
			_notebookData = NotebookSerializer.Load();
		}
		catch
		{
			MessageBox.Show($"Failed to load notebook from {NotebookSerializer.Path}, " +
				$"file with notebook data corrupted.", "Error occured.");
		}

		foreach (NoteCategory noteCategoryType in Enum.GetValues(typeof(NoteCategory)))
		{
			CategoryComboBox.Items.Add(noteCategoryType);
		}
		CategoryComboBox.SelectedIndex = 0;

		DisplayNoteContent(_notebookData.LastOpenNote);
		UpdateNoteListBox();
	}

	/// <summary>
	/// Обновить содержимое списка заметок.
	/// </summary>
	private void UpdateNoteListBox()
	{
		NoteCategory selectedNoteCategory = (NoteCategory)CategoryComboBox.SelectedItem;
		List<Note> notes = _notebookData.GetNotesWithCategory(selectedNoteCategory);

		_displayedNotebook.Clear();
		_displayedNotebook.AddRange(notes, 0);

		NotesListBox.Items.Clear();
		for (int i = 0; i < _displayedNotebook.NotesCount; ++i)
		{
			NotesListBox.Items.Add(_displayedNotebook[i].Title);
		}
	}

	/// <summary>
	/// Отобразить содержимое заданной заметки на экране.
	/// </summary>
	/// <param name="note">Заметка для отображения.</param>
	private void DisplayNoteContent(Note note)
	{
		NoteTitleLabel.Text = note.Title;
		NoteCategoryLabel.Text = $"Category: {note.Category}";
		NoteTextRichTextBox.Text = note.Text;
		NoteCreationDateTime.Value = note.CreationTime;
		NoteModificationDateTime.Value = note.ModificationTime;
	}

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
		NoteForm noteForm = new();
		noteForm.Note = newNote;
		DialogResult result = noteForm.ShowDialog();
		if (result == DialogResult.OK)
		{
			_notebookData.AddNote(newNote);
			NotebookSerializer.Save(_notebookData);
			DisplayNoteContent(newNote);
			UpdateNoteListBox();
		}
	}

	/// <summary>
	/// Редактировать выбранную заметку.
	/// </summary>
	private void EditNoteButton_Click(object sender, EventArgs e)
	{
		int selectedNoteIndex = NotesListBox.SelectedIndex;
		if (selectedNoteIndex == -1)
		{
			MessageBox.Show("Please select what note need to be edited.", "Error occured.");
			return;
		}

		Note selectedNote = _displayedNotebook[selectedNoteIndex];
		NoteForm noteForm = new();
		noteForm.Note = selectedNote;
		DialogResult result = noteForm.ShowDialog();
		if (result == DialogResult.OK)
		{
			NotebookSerializer.Save(_notebookData);
			DisplayNoteContent(selectedNote);
			UpdateNoteListBox();
		}
	}

	/// <summary>
	/// Удалить выбранную заметку.
	/// </summary>
	private void RemoveNoteButton_Click(object sender, EventArgs e)
	{
		int selectedNoteIndex = NotesListBox.SelectedIndex;
		if (selectedNoteIndex == -1)
		{
			MessageBox.Show("Please select what note need to be removed.", "Error occured.");
			return;
		}

		Note noteToDelete = _displayedNotebook[selectedNoteIndex];
		_notebookData.RemoveNote(noteToDelete);
		_notebookData.SortNotesByModification();
		NotesListBox.SelectedIndex = -1;
		UpdateNoteListBox();

		NotebookSerializer.Save(_notebookData);
	}

	/// <summary>
	/// Обновить содержимое выбранной заметки на экране.
	/// </summary>
	private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (NotesListBox.SelectedIndex != -1)
		{
			Note selectedNote = _displayedNotebook.ViewNote(NotesListBox.SelectedIndex);
			_notebookData.LastOpenNote = selectedNote;
			DisplayNoteContent(selectedNote);
			return;
		}

		Note lastOpenNote = _notebookData.LastOpenNote;
		NoteTitleLabel.Text = lastOpenNote.Title;
		NoteCategoryLabel.Text = $"Category: {lastOpenNote.Category}";
		NoteTextRichTextBox.Text = lastOpenNote.Text;
		NoteCreationDateTime.Value = DateTime.Now;
		NoteModificationDateTime.Value = DateTime.Now;
	}

	/// <summary>
	/// Сортировка заметок по заданной категории.
	/// </summary>
	private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
	{
		UpdateNoteListBox();
	}

	/// <summary>
	/// Сохранение заметок в файл во время закрытия.
	/// </summary>
	private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		NotebookSerializer.Save(_notebookData);
	}

	/// <summary>
	/// Закрытие приложения через меню.
	/// </summary>
	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Close();
	}
}