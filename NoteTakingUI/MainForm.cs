using NoteTaking;

namespace NoteTakingUI;

// TODO: + добавить иконку приложению
// TODO: + верстка слетела, контролы за пределами формы
// TODO: + После Show Category поставить двоеточие. В конце любыхх лейблов ставится двоеточие, если это только не подсказка
// TODO: + комбобокс на выбор категории не работает
// TODO: + если заметка достаточно большая, то её нельзя пролистнуть с помощью скроллера
// TODO: + сделать кнопки на добавление/редактирование и удаление плоскими и с пиктограммами, как на макете интерфейса
// TODO: + заметки не сортируются по дате модификации

public partial class MainForm : Form
{
	// TODO: + неправильное использование xml-комментариев
	// TODO: + неправильный порядок членов класса
	/// <summary>
	/// Список заметок.
	/// </summary>
	private Notebook _notesData;

	/// <summary>
	/// Список заметок для отображения на экране.
	/// </summary>
	private Notebook _displayedNotes;

	/// <summary>
	/// Справочная заметка.
	/// </summary>
	private Note _helpNote = new Note($"It's the title of this help note.", "Create your first note by clicking on the button in the lower left corner or select existed one on the left box.");

	/// <summary>
	/// Конструктор формы по умолчанию.
	/// </summary>
	public MainForm()
	{
		InitializeComponent();

		_notesData = new();
		_displayedNotes = _notesData;

		// TODO: + путь сохранения должен определятся в бизнес-логике или классе Program, но не в самой MainForm
		// TODO: + после установки программы, путь к файлу будет лежать в папке Program Files, а к ней доступ запрещен. Должна быть работа с папкой AppData - специальной папкой для временных файлов любых программ
		// TODO: + если какое-то значение повторяется несколько раз - надо выносить в константу или переменную
		if (File.Exists(NotebookSerializer.Path))
		{
			try
			{
				_notesData = NotebookSerializer.Load();
			}
			catch
			{
				MessageBox.Show(string.Format("Failed to load notebook from {0}, check whatever file exist or maybe corrupted.", NotebookSerializer.Path), "Error occured.");
			}
		}

		foreach (NoteCategoryType noteCategoryType in Enum.GetValues(typeof(NoteCategoryType)))
		{
			CategoryComboBox.Items.Add(noteCategoryType);
		}
		CategoryComboBox.SelectedIndex = 0;

		DisplayNoteContent(_helpNote);
		UpdateNoteListBox();
	}

	/// <summary>
	/// Обновить содержимое списка заметок.
	/// </summary>
	private void UpdateNoteListBox()
	{
		_displayedNotes = _notesData.GetNotesWithCategory((NoteCategoryType)CategoryComboBox.SelectedItem);
		NotesListBox.Items.Clear();
		for (int i = 0; i < _displayedNotes.NotesCount; ++i)
		{
			NotesListBox.Items.Add(_displayedNotes[i].Title);
		}
	}

	/// <summary>
	/// Отобразить содержимое заданной заметки на экране.
	/// </summary>
	/// <param name="note">Заметка для отображения.</param>
	private void DisplayNoteContent(Note note)
	{
		NoteTitleLabel.Text = note.Title;
		NoteCategoryLabel.Text = string.Format("Category: {0}", note.Category);
		NoteTextRichTextBox.Text = note.Text;
		NoteCreateDateTime.Value = note.CreatingTime;
		NoteModifiedDateTime.Value = note.ModifiedTime;
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
		NoteForm noteEditForm = new();
		noteEditForm.Note = newNote;
		DialogResult result = noteEditForm.ShowDialog();
		if (result == DialogResult.OK)
		{
			_notesData.AddNote(newNote);
			DisplayNoteContent(newNote);
			UpdateNoteListBox();
		}
	}

	/// <summary>
	/// Редактировать выбранную заметку.
	/// </summary>
	private void EditNoteButton_Click(object sender, EventArgs e)
	{
		// TODO: + Термин "редактировать" у тебя переводится и как Edit, и как Change. Должен быть только один правильный перевод термина. PS: Change - не переводится как "редактировать"
		int selectedNoteIndex = NotesListBox.SelectedIndex;
		try
		{
			Note selectedNote = _displayedNotes[selectedNoteIndex];
			NoteForm noteEditForm = new();
			noteEditForm.Note = selectedNote;
			DialogResult result = noteEditForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				// TODO: + по заданию любые изменения списка заметок должны тут же сохраняться в файл
				NotebookSerializer.Save(_notesData);
				DisplayNoteContent(selectedNote);
				UpdateNoteListBox();
			}
		}
		catch
		{
			MessageBox.Show("Please select what note need to be edited.", "Error occured.");
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
			_displayedNotes[selectedNoteIndex].Title = "Note to delete";
			_notesData.SortNotesByModification();
			_notesData.RemoveNote(0);
			NotesListBox.SelectedIndex = -1;
			UpdateNoteListBox();
		}
		catch
		{
			MessageBox.Show("Please select what note need to be removed.", "Error occured.");
		}
	}

	/// <summary>
	/// Обновить содержимое выбранной заметки на экране.
	/// </summary>
	private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
	{
		// TODO: + если индекс -1, то надо очищать данные на форме (например, когда пользователь удалил все заметки, или нет заметок, подходящих под выбранную категорию
		if (NotesListBox.SelectedIndex != -1)
		{
			Note selectedNote = _displayedNotes[NotesListBox.SelectedIndex];
			DisplayNoteContent(selectedNote);
		}
		else
		{
			NoteTitleLabel.Text = "";
			NoteCategoryLabel.Text = "Category:";
			NoteTextRichTextBox.Text = "";
			NoteCreateDateTime.Value = DateTime.Now;
			NoteModifiedDateTime.Value = DateTime.Now;
		}
	}

	/// <summary>
	/// Сортировка заметок по заданной категории.
	/// </summary>
	private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
	{
		// TODO: + обновление листбокса вынести в отдельный метод и вызывать везде, где требуется обновлять
		UpdateNoteListBox();
	}

	/// <summary>
	/// Сохранение заметок в файл во время закрытия.
	/// </summary>
	private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		NotebookSerializer.Save(_notesData);
	}

	/// <summary>
	/// Закрытие приложения через меню.
	/// </summary>
	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Close();
	}
}