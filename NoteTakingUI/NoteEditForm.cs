using NoteTaking;

namespace NoteTakingUI;

// TODO: В окне должна быть валидация на длину заголовка
// TODO: именование формы поменять на NoteForm. Форма может создавать и редактировать заметки, а не только редактировать
/// <summary>
/// Форма для редактирования содержимого выбранной заметки.
/// </summary>
public partial class NoteEditForm : Form
{
	/// <summary>
	/// Конструкторы.
	/// </summary>

	// TODO: Если есть get-свойство EditedNote, тогда лучше сделать свойству set вместо передачи заметки в конструктор
	/// <summary>
	/// Конструктор без параметров.
	/// </summary>
	public NoteEditForm(Note noteToEdit)
	{
		InitializeComponent();

		_noteToEdit = noteToEdit;

		NoteTitleTextBox.Text = _noteToEdit.Title;
		NoteTextRichTextBox.Text = _noteToEdit.Text;
		NoteCreateDateTime.Value = _noteToEdit.CreatingTime;
		NoteModifiedDateTime.Value = _noteToEdit.ModifiedTime;
		foreach (NoteCategoryType noteType in Enum.GetValues(typeof(NoteCategoryType)))
		{
			NoteCategoryComboBox.Items.Add(noteType);
		}
		NoteCategoryComboBox.SelectedItem = _noteToEdit.Category;
	}

	/// <summary>
	/// Свойства.
	/// </summary>

	// TODO: просто Note
	/// <summary>
	/// Редактированная заметка.
	/// </summary>
	public Note EditedNote
	{
		get { return _noteToEdit; }
	}

	// TODO: что за "именты"?
	/// <summary>
	/// Именты.
	/// </summary>

	/// <summary>
	/// Принять внесённые изменения в заметку.
	/// </summary>
	private void OkButton_Click(object sender, EventArgs e)
	{
		_noteToEdit.Title = NoteTitleTextBox.Text;
		_noteToEdit.Text = NoteTextRichTextBox.Text;
		_noteToEdit.Category = (NoteCategoryType)NoteCategoryComboBox.SelectedItem;

		DialogResult = DialogResult.OK;
		Close();
	}

	/// <summary>
	/// Отменить внесённые изменения в заметке.
	/// </summary>
	private void CancelButton_Click(object sender, EventArgs e)
	{
		DialogResult = DialogResult.Cancel;
		Close();
	}

	/// <summary>
	/// Реализация.
	/// </summary>

	/// <summary>
	/// Текущая выбранная заметка для редактирования в этой форме.
	/// </summary>
	private Note _noteToEdit;
}