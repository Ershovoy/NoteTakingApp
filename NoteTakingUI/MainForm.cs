using NoteTaking;

namespace NoteTakingUI;

public partial class MainForm : Form
{
	// TODO: кнопки в интерфейсе не плоские. Убрать рамку, убрать фон другого цвета

	// TODO: + название поле скрывает, что это объект Notebook. Ожидания, что это какой-то DataSet для таблицы, например, а здесь объект целого класса
	/// <summary>
	/// Список заметок.
	/// </summary>
	private Notebook _notebookData;

	/// <summary>
	/// Список заметок для отображения на экране.
	/// </summary>
	private Notebook _displayedNotebook;

	// TODO: + длинная строка
	/// <summary>
	/// Справочная заметка.
	/// </summary>
	private Note _helpNote = new Note($"It's the title of this help note.",
		"Create your first note by clicking on the button in the lower left corner " +
		"or select existed one on the left box.");

	/// <summary>
	/// Конструктор формы по умолчанию.
	/// </summary>
	public MainForm()
	{
		InitializeComponent();

		_notebookData = new Notebook();
		_displayedNotebook = _notebookData;

		// TODO: + проверкой существования файла должен заниматься сериалайзер.
		// Чем меньше логики в окнах, тем лучше. Здесь должен остаться только вызов MessageBox.
		try
		{
			_notebookData = NotebookSerializer.Load();
		}
		catch (FileNotFoundException exception)
		{
			MessageBox.Show(exception.Message, "Error occured.");
		}
		catch
		{
			// TODO: + длинная строка
			// TODO: + вместо string.Format люди давно используют интерполяцию строк
			MessageBox.Show($"Failed to load notebook from {NotebookSerializer.Path}, " +
				$"file with notebook data corrupted.", "Error occured.");
		}


		foreach (NoteCategory noteCategoryType in Enum.GetValues(typeof(NoteCategory)))
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
		// TODO: + не надо нагромождать всё в одну строку. Бей на строки, создавай локальные переменные.
		// Лучше всего читается код, когда в одной строке одно действие
		NoteCategory selectedNoteCategory = (NoteCategory)CategoryComboBox.SelectedItem;
		List<Note> notes = _notebookData.GetNotesWithCategory(selectedNoteCategory);
		// TODO: + заменить на AddRange, когда будет изменен возвращаемый тип данных метода GetNotesWithCategory()
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
		// TODO: + интерполяция строк
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
		// TODO: + имя локальной переменной отличается от имени класса - недопереименовал
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
		// TODO: + вместо тяжелого и медленного механизма try-catch быстрее и проще в начале метода проверить index на -1 и показать сообщение.
		// Работать будет быстрее, а из метода исчезнет вложенность из-за блока try.
		if (selectedNoteIndex == -1)
		{
			MessageBox.Show("Please select what note need to be edited.", "Error occured.");
			return;
		}

		Note selectedNote = _displayedNotebook[selectedNoteIndex];
		// TODO: + опять имя локальной переменной
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
		// TODO: + заменить try-catch на if в начале метода.
		if (selectedNoteIndex == -1)
		{
			MessageBox.Show("Please select what note need to be removed.", "Error occured.");
			return;
		}

		// TODO: + зачем замена заголовка?
		Note noteToDelete = _displayedNotebook[selectedNoteIndex];
		_notebookData.RemoveNote(noteToDelete);
		_notebookData.SortNotesByModification();
		NotesListBox.SelectedIndex = -1;
		UpdateNoteListBox();
		// TODO: + Нет пересохранения после удаления заметки - данные ведь изменились
		NotebookSerializer.Save(_notebookData);
	}

	/// <summary>
	/// Обновить содержимое выбранной заметки на экране.
	/// </summary>
	private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (NotesListBox.SelectedIndex != -1)
		{
			Note selectedNote = _displayedNotebook[NotesListBox.SelectedIndex];
			DisplayNoteContent(selectedNote);
			return;
		}

		// TODO: + чтобы не делать допвложенность, можно удалить else, а в ветке под условием if добавить оператор return
		NoteTitleLabel.Text = "";
		NoteCategoryLabel.Text = "Category:";
		NoteTextRichTextBox.Text = "";
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