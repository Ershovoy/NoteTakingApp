using NoteTaking;

namespace NoteTakingUI;

/// <summary>
/// Форма для редактирования содержимого выбранной заметки.
/// </summary>
public partial class NoteForm : Form
{
	// TODO: + зачем фраза ToEdit? 1) поле именуется как и свойство. Свойство переименовал, почему поле оставил? Не надо нагромождать названия лишними словами
	/// <summary>
	/// Текущая выбранная заметка для редактирования в этой форме.
	/// </summary>
	private Note _note;

	// TODO: + просто Note
	/// <summary>
	/// Редактированная заметка.
	/// </summary>
	public Note Note
	{
		get { return _note; }
		set
		{
			_note = value;

			NoteTitleTextBox.Text = _note.Title;
			NoteTextRichTextBox.Text = _note.Text;
			NoteCreationDateTime.Value = _note.CreationTime;
			NoteModificationDateTime.Value = _note.ModificationTime;
			NoteCategoryComboBox.SelectedItem = _note.Category;
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

		foreach (NoteCategory noteType in Enum.GetValues(typeof(NoteCategory)))
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
		// TODO: + валидация должна в бизнес-логике, а форма должна просто ловить исключения с ошибками и показывать из них текст пользователю.
		try
		{
			_note.Title = NoteTitleTextBox.Text;
		}
		catch (ArgumentException exception)
		{
			MessageBox.Show(exception.Message, "Error occured.");
			return;
		}
		_note.Text = NoteTextRichTextBox.Text;
		_note.Category = (NoteCategory)NoteCategoryComboBox.SelectedItem;

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