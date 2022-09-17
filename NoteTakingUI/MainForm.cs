using NoteTaking;

namespace NoteTakingUI;

public partial class MainForm : Form
{
	// TODO: кнопки в интерфейсе не плоские. Убрать рамку, убрать фон другого цвета

	// TODO: название поле скрывает, что это объект Notebook. Ожидания, что это какой-то DataSet для таблицы, например, а здесь объект целого класса
	/// <summary>
	/// Список заметок.
	/// </summary>
	private Notebook _notesData;

	/// <summary>
	/// Список заметок для отображения на экране.
	/// </summary>
	private Notebook _displayedNotes;

	// TODO: длинная строка
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

		// TODO: проверкой существования файла должен заниматься сериалайзер. Чем меньше логики в окнах, тем лучше. Здесь должен остаться только вызов MessageBox.
		if (File.Exists(NotebookSerializer.Path))
		{
			try
			{
				_notesData = NotebookSerializer.Load();
			}
			catch
			{
				// TODO: длинная строка
				// TODO: вместо string.Format люди давно используют интерполяцию строк
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
		// TODO: не надо нагромождать всё в одну строку. Бей на строки, создавай локальные переменные.
		// Лучше всего читается код, когда в одной строке одно действие
		_displayedNotes = _notesData.GetNotesWithCategory((NoteCategoryType)CategoryComboBox.SelectedItem);
		NotesListBox.Items.Clear();
		// TODO: заменить на AddRange, когда будет изменен возвращаемый тип данных метода GetNotesWithCategory()
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
		// TODO: интерполяция строк
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
		// TODO: имя локальной переменной отличается от имени класса - недопереименовал
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
		int selectedNoteIndex = NotesListBox.SelectedIndex;
		try
		{
			Note selectedNote = _displayedNotes[selectedNoteIndex];
			// TODO: опять имя локальной переменной
			NoteForm noteEditForm = new();
			noteEditForm.Note = selectedNote;
			DialogResult result = noteEditForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				NotebookSerializer.Save(_notesData);
				DisplayNoteContent(selectedNote);
				UpdateNoteListBox();
			}
		}
		catch
		{
			// TODO: вместо тяжелого и медленного механизма try-catch быстрее и проще в начале метода проверить index на -1 и показать сообщение.
			// Работать будет быстрее, а из метода исчезнет вложенность из-за блока try.
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
			// TODO: зачем замена заголовка?
			_displayedNotes[selectedNoteIndex].Title = "Note to delete";
			_notesData.SortNotesByModification();
			_notesData.RemoveNote(0);
			NotesListBox.SelectedIndex = -1;
			UpdateNoteListBox();
		}
		catch
		{
			// TODO: заменить try-catch на if в начале метода.
			MessageBox.Show("Please select what note need to be removed.", "Error occured.");
		}
		// TODO: Нет пересохранения после удаления заметки - данные ведь изменились
	}

	/// <summary>
	/// Обновить содержимое выбранной заметки на экране.
	/// </summary>
	private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (NotesListBox.SelectedIndex != -1)
		{
			Note selectedNote = _displayedNotes[NotesListBox.SelectedIndex];
			DisplayNoteContent(selectedNote);
		}
		else
		{
			// TODO: чтобы не делать допвложенность, можно удалить else, а в ветке под условием if добавить оператор return
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