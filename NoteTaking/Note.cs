using Newtonsoft.Json;

namespace NoteTaking;

/// <summary>
/// Класс описывающий заметку.
/// </summary>
public class Note
{
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

    // TODO: зачем делать все поля как JsonProperty, но при этом игнорировать все свойства? Куча лишних атрибутов, можно реализовать без них. Например, сделав закрытый конструктор для сериализации
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

    // TODO: класс должен сам валидировать поле на длину. Где проверка?
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

    // TODO: в интерфейсе свойство называется Created. Где правда? Исправить, сделать единообразно везде
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

    /// <summary>
    /// Создание заметки по заданному заголовку, содержимому и её категории.
    /// </summary>
    /// <param name="title">Заголовок заметки.</param>
    /// <param name="text">Содержимое заметки.</param>
    /// <param name="noteCategory">Категория заметки.</param>
	// TODO: не должно быть строк длиннее 100 символов, исправить
    public Note(string title = _defaultNoteTitle, string text = _defaultNoteText, NoteCategoryType noteCategory = _defaultNoteCategory)
	{
		Title = title;
		Text = text;
		Category = noteCategory;
	}
}