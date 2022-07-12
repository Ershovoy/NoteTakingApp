namespace NoteTaking;

/// <summary>
/// Класс описывающий заметку.
/// </summary>
public class Note
{
	// TODO: порядом членов класса: константы, static и readonly поля, обычные поля, свойства, конструкторы, открытые методы, закрытые методы, обработчики. Переделать порядок членов класса во всём решении 
	// TODO: xml-комментарии не используются сами по себе, только перед методом, классом, полем
	/// <summary>
	/// Конструкторы.
	/// </summary>

	/// <summary>
	/// Cоздаёт заметку со значениями по умолчанию.
	/// </summary>
	public Note()
	{
		Title = _defaultNoteTitle;
		Text = _defaultNoteText;
		Category = _defaultNoteCategory;
	}
	
	/// <summary>
	/// Создание заметки по заданному заголовку, остальные поля примут значения по умолчанию.
	/// </summary>
	/// <param name="title">Заголовок заметки.</param>
	public Note(string title)
	{
		Title = title;
		Text = _defaultNoteText;
		Category = _defaultNoteCategory;
	}

	/// <summary>
	/// Создание заметки по заданному заголовку и содержимому, поле категории примет значение по умолчанию.
	/// </summary>
	/// <param name="title">Заголовок заметки.</param>
	/// <param name="text">Содержимое заметки.</param>
	public Note(string title, string text)
	{
		Title = title;
		Text = text;
		Category = _defaultNoteCategory;
	}

	// TODO: три конструктора можно было бы реализовать одним методом с параметрами по умолчанию или явным наследованием от конструктора
	/// <summary>
	/// Создание заметки по заданному заголовку, содержимому и её категории.
	/// </summary>
	/// <param name="title">Заголовок заметки.</param>
	/// <param name="text">Содержимое заметки.</param>
	/// <param name="noteCategory">Категория заметки.</param>
	public Note(string title, string text, NoteCategoryType noteCategory)
	{
		Title = title;
		Text = text;
		Category = noteCategory;
	}

	// TODO: неправильное использование комментария
	/// <summary>
	/// Свойства.
	/// </summary>

	/// <summary>
	/// Заголовок заметки.
	/// </summary>
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
	public DateTime CreatingTime
	{
		get { return _creatingTime; }
	}

	/// <summary>
	/// Время последного изменения заметки.
	/// </summary>
	public DateTime ModifiedTime
	{
		get { return _modifiedTime; }
	}

	// TODO: неправильное использование комментария
	/// <summary>
	/// Реализация.
	/// </summary>

	/// <summary>
	/// Заголовок заметки.
	/// </summary>
	private string _title;

	/// <summary>
	/// Основной текст заметки.
	/// </summary>
	private string _text;

	/// <summary>
	/// Категория заметки.
	/// </summary>
	private NoteCategoryType _category;

	/// <summary>
	/// Время создания заметки.
	/// </summary>
	private DateTime _creatingTime = DateTime.Now;

	/// <summary>
	/// Время последнего изменения заметки.
	/// </summary>
	private DateTime _modifiedTime = DateTime.Now;

	// TODO: static readonly - это const
	/// <summary>
	/// Стандартный заголовок заметки.
	/// </summary>
	private static readonly string _defaultNoteTitle = "Untitled Note";

	/// <summary>
	/// Содержимое заметки по умолчанию.
	/// </summary>
	private static readonly string _defaultNoteText = "Write your note here.";

	/// <summary>
	/// Стандартная категория заметки.
	/// </summary>
	private static readonly NoteCategoryType _defaultNoteCategory = NoteCategoryType.Default;

}
