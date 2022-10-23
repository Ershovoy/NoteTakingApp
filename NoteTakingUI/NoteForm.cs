using NoteTaking;

namespace NoteTakingUI;

/// <summary>
/// Форма для редактирования содержимого выбранной заметки.
/// </summary>
public partial class NoteForm : Form
{
	/// <summary>
	/// Текущая выбранная заметка для редактирования в этой форме.
	/// </summary>
	private Note _note;

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

	/// <summary>
	/// Принять внесённые изменения в заметку.
	/// </summary>
	private void OkButton_Click(object sender, EventArgs e)
	{
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