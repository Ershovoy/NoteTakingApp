using NoteTaking;

namespace NoteTakingUI;

// TODO: В окне должна быть валидация на длину заголовка
// TODO: + именование формы поменять на NoteForm. Форма может создавать и редактировать заметки, а не только редактировать
/// <summary>
/// Форма для редактирования содержимого выбранной заметки.
/// </summary>
public partial class NoteForm : Form
{
	/// <summary>
	/// Текущая выбранная заметка для редактирования в этой форме.
	/// </summary>
	private Note _noteToEdit;

	// TODO: + просто Note
	/// <summary>
	/// Редактированная заметка.
	/// </summary>
	public Note Note
	{
		get { return _noteToEdit; }
		set
		{
			_noteToEdit = value;

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
	}

	// TODO: + Если есть get-свойство EditedNote, тогда лучше сделать свойству set вместо передачи заметки в конструктор
	/// <summary>
	/// Конструктор без параметров.
	/// </summary>
	public NoteForm()
	{
		InitializeComponent();
		Note = new Note();
	}

	// TODO: + что за "именты"?
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
}