using Newtonsoft.Json;

namespace NoteTaking;

/// <summary>
/// Класс описывающий заметку.
/// </summary>
public class Note
{
	// TODO: + порядом членов класса: константы, static и readonly поля, обычные поля, свойства, конструкторы, открытые методы, закрытые методы, обработчики. Переделать порядок членов класса во всём решении 
	// TODO: + xml-комментарии не используются сами по себе, только перед методом, классом, полем
	// TODO: + static readonly - это const
	/// <summary>
	/// Стандартный заголовок заметки.
	/// </summary>
	private const string _defaultNoteTitle = "Untitled Note";

	/// <summary>
	/// Содержимое заметки по умолчанию.
	/// </summary>
	private const string _defaultNoteText = "Write your note here.";

	/// <summary>
	/// Стандартная категория заметки.
	/// </summary>
	private const NoteCategoryType _defaultNoteCategory = NoteCategoryType.Default;

	/// <summary>
	/// Заголовок заметки.
	/// </summary>
	[JsonProperty]
	private string _title;

	/// <summary>
	/// Основной текст заметки.
	/// </summary>
	[JsonProperty]
	private string _text;

	// TODO: + неправильное использование комментария
	/// <summary>
	/// Категория заметки.
	/// </summary>
	[JsonProperty]
	private NoteCategoryType _category;

	/// <summary>
	/// Время создания заметки.
	/// </summary>
	[JsonProperty]
	private DateTime _creatingTime = DateTime.Now;

	/// <summary>
	/// Время последнего изменения заметки.
	/// </summary>
	[JsonProperty]
	private DateTime _modifiedTime = DateTime.Now;

	// TODO: + неправильное использование комментария
	/// <summary>
	/// Заголовок заметки.
	/// </summary>
	[JsonIgnore]
	public string Title
	{
		get { return _title; }
		set
		{
			_title = value;
			_modifiedTime = DateTime.Now;
		}
	}

	/// <summary>
	/// Содержимое заметки.
	/// </summary>
	[JsonIgnore]
	public string Text
	{
		get { return _text; }
		set
		{
			_text = value;
			_modifiedTime = DateTime.Now;
		}
	}

	/// <summary>
	/// Категория заметки.
	/// </summary>
	[JsonIgnore]
	public NoteCategoryType Category
	{
		get { return _category; }
		set
		{
			_category = value;
			_modifiedTime = DateTime.Now;
		}
	}

	/// <summary>
	/// Время создания заметки.
	/// </summary>
	[JsonIgnore]
	public DateTime CreatingTime
	{
		get { return _creatingTime; }
	}

	/// <summary>
	/// Время последного изменения заметки.
	/// </summary>
	[JsonIgnore]
	public DateTime ModifiedTime
	{
		get { return _modifiedTime; }
	}

	// TODO: + три конструктора можно было бы реализовать одним методом с параметрами по умолчанию или явным наследованием от конструктора
	/// <summary>
	/// Создание заметки по заданному заголовку, содержимому и её категории.
	/// </summary>
	/// <param name="title">Заголовок заметки.</param>
	/// <param name="text">Содержимое заметки.</param>
	/// <param name="noteCategory">Категория заметки.</param>
	public Note(string title = _defaultNoteTitle, string text = _defaultNoteText, NoteCategoryType noteCategory = _defaultNoteCategory)
	{
		Title = title;
		Text = text;
		Category = noteCategory;
	}
}