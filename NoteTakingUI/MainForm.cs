using NoteTaking;

namespace NoteTakingUI;

// TODO: добавить иконку приложению
// TODO: верстка слетела, контролы за пределами формы
// TODO: После Show Category поставить двоеточие. В конце любыхх лейблов ставится двоеточие, если это только не подсказка
// TODO: комбобокс на выбор категории не работает
// TODO: если заметка достаточно большая, то её нельзя пролистнуть с помощью скроллера
// TODO: сделать кнопки на добавление/редактирование и удаление плоскими и с пиктограммами, как на макете интерфейса
// TODO: заметки не сортируются по дате модификации

public partial class MainForm : Form
{
	// TODO: неправильное использование xml-комментариев
	// TODO: неправильный порядок членов класса
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

		foreach (NoteCategoryType noteCategoryType in Enum.GetValues(typeof(NoteCategoryType)))
		{
			CategoryComboBox.Items.Add(noteCategoryType);
		}
		CategoryComboBox.SelectedIndex = 0;
		// TODO: путь сохранения должен определятся в бизнес-логике или классе Program, но не в самой MainForm
		// TODO: после установки программы, путь к файлу будет лежать в папке Program Files, а к ней доступ запрещен. Должна быть работа с папкой AppData - специальной папкой для временных файлов любых программ
		if (File.Exists(@"NotesSaveData.txt"))
		{
			// TODO: если какое-то значение повторяется несколько раз - надо выносить в константу или переменную
			_notes.Load(@"NotesSaveData.txt");
			for (int i = 0; i < _notes.NotesCount; ++i)
			{
				NotesListBox.Items.Add(_notes[i].Title);
			}
		}
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
		// TODO: Термин "редактировать" у тебя переводится и как Edit, и как Change. Должен быть только один правильный перевод термина. PS: Change - не переводится как "редактировать"
		int selectedNoteIndex = NotesListBox.SelectedIndex;
		try
		{
			Note selectedNote = _notes[selectedNoteIndex];
			NoteEditForm noteEditForm = new(selectedNote);
			DialogResult result = noteEditForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				// TODO: по заданию любые изменения списка заметок должны тут же сохраняться в файл
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
		// TODO: если индекс -1, то надо очищать данные на форме (например, когда пользователь удалил все заметки, или нет заметок, подходящих под выбранную категорию
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
	/// Сортировка заметок по заданной категории.
	/// </summary>
	private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
	{
		_notes.SortBy((NoteCategoryType)CategoryComboBox.SelectedItem);
		// TODO: обновление листбокса вынести в отдельный метод и вызывать везде, где требуется обновлять
		NotesListBox.Items.Clear();
		for (int i = 0; i < _notes.NotesCount; ++i)
		{
			NotesListBox.Items.Add(_notes[i].Title);
		}
	}

	/// <summary>
	/// Сохранение заметок в файл во время закрытия.
	/// </summary>
	private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		_notes.Save(@"NotesSaveData.txt");
	}

	/// <summary>
	/// Закрытие приложения через меню.
	/// </summary>
	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Close();
	}

	/// <summary>
	/// Реализация.
	/// </summary>

	/// <summary>
	/// Список заметок.
	/// </summary>
	private Notebook _notes;
}