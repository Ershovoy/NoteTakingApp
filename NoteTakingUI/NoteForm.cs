using NoteTaking;

namespace NoteTakingUI;

/// <summary>
/// Форма для редактирования содержимого выбранной заметки.
/// </summary>
public partial class NoteForm : Form
{
    // TODO: зачем фраза ToEdit? 1) поле именуется как и свойство. Свойство переименовал, почему поле оставил? Не надо нагромождать названия лишними словами
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

		foreach (NoteCategoryType noteType in Enum.GetValues(typeof(NoteCategoryType)))
		{
			NoteCategoryComboBox.Items.Add(noteType);
		}
	}

	// TODO: + что за "именты"?
	/// <summary>
	/// Принять внесённые изменения в заметку.
	/// </summary>
	private void OkButton_Click(object sender, EventArgs e)
	{
        // TODO: валидация должна в бизнес-логике, а форма должна просто ловить исключения с ошибками и показывать из них текст пользователю.
        if (NoteTitleTextBox.Text.Length > 15)
		{
			MessageBox.Show("The note title must be less than 15 characters.", "Error occured.");
			return;
		}
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