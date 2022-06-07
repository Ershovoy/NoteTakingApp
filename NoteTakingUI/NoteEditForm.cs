using NoteTaking;

namespace NoteTakingUI;

/// <summary>
/// Форма для редактирования содержимого выбранной заметки.
/// </summary>
public partial class NoteEditForm : Form
{
	/// <summary>
	/// Конструкторы.
	/// </summary>

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
		foreach(string noteType in Enum.GetNames(typeof(NoteCategoryType)))
		{
			NoteCategoryComboBox.Items.Add(noteType);
		}
		NoteCategoryComboBox.SelectedIndex = (int)_noteToEdit.Category;
	}

	/// <summary>
	/// Свойства.
	/// </summary>

	/// <summary>
	/// Редактированная заметка.
	/// </summary>
	public Note EditedNote
	{
		get { return _noteToEdit; }
	}

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
		_noteToEdit.Category = (NoteCategoryType)NoteCategoryComboBox.SelectedIndex;

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