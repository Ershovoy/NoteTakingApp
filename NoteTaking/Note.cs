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
	private const NoteCategory _defaultNoteCategory = NoteCategory.Undefined;

	/// <summary>
	/// Максимальная длина заголовка заметки.
	/// </summary>
	private const int _maxTitleLength = 40;

	// TODO: ? зачем делать все поля как JsonProperty, но при этом игнорировать все свойства?
	// Куча лишних атрибутов, можно реализовать без них. Например, сделав закрытый конструктор для сериализации
	/// <summary>
	/// Заголовок заметки.
	/// </summary>
	private string _title;

	/// <summary>
	/// Основной текст заметки.
	/// </summary>
	private string _text;

	// TODO: + неправильное использование комментария
	/// <summary>
	/// Категория заметки.
	/// </summary>
	private NoteCategory _category;

	/// <summary>
	/// Время создания заметки.
	/// </summary>
	private DateTime _creationTime = DateTime.Now;

	/// <summary>
	/// Время последнего изменения заметки.
	/// </summary>
	private DateTime _modificationTime = DateTime.Now;

	// TODO: + класс должен сам валидировать поле на длину. Где проверка?
	/// <summary>
	/// Заголовок заметки.
	/// </summary>
	public string Title
	{
		get { return _title; }
		set
		{
			if (value != null && value.Length > _maxTitleLength)
			{
				throw new ArgumentException($"The note title must be less than {_maxTitleLength} characters.");
			}

			_title = value;
			_modificationTime = DateTime.Now;
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
			_modificationTime = DateTime.Now;
		}
	}

	/// <summary>
	/// Категория заметки.
	/// </summary>
	public NoteCategory Category
	{
		get { return _category; }
		set
		{
			_category = value;
			_modificationTime = DateTime.Now;
		}
	}

	// TODO: + в интерфейсе свойство называется Created. Где правда? Исправить, сделать единообразно везде
	/// <summary>
	/// Время создания заметки.
	/// </summary>
	public DateTime CreationTime
	{
		get { return _creationTime; }
		private set 
		{
			if(CreationTime > ModificationTime)
			{
				throw new ArgumentException("Creation time must happen before modification time.");
			}

			_creationTime = value;
		}
	}

	/// <summary>
	/// Время последного изменения заметки.
	/// </summary>
	public DateTime ModificationTime
	{
		get { return _modificationTime; }
		private set
		{
			if (ModificationTime < CreationTime)
			{
				throw new ArgumentException("Modification time must happen before creation time.");
			}

			_modificationTime = value;
		}
	}

	/// <summary>
	/// Создание заметки по заданному заголовку, содержимому и её категории.
	/// </summary>
	/// <param name="title">Заголовок заметки.</param>
	/// <param name="text">Содержимое заметки.</param>
	/// <param name="noteCategory">Категория заметки.</param>
	// TODO: + не должно быть строк длиннее 100 символов, исправить
	public Note(string title = _defaultNoteTitle,
		string text = _defaultNoteText,
		NoteCategory noteCategory = _defaultNoteCategory)
	{
		Title = title;
		Text = text;
		Category = noteCategory;
	}

	/// <summary>
	/// Закрытый конструктор вызываемый во время сериализации.
	/// </summary>
	/// <param name="title">Заголовок заметки.</param>
	/// <param name="text">Содержимое заметки.</param>
	/// <param name="category">Категория заметки.</param>
	/// <param name="creationTime">Время создания заметки.</param>
	/// <param name="modificationTime">Время последнего изменения заметки.</param>
	[JsonConstructor]
	private Note(string title, string text, NoteCategory category,
		DateTime creationTime, DateTime modificationTime)
		: this(title, text, category)
	{
		Title = title;
		Text = text;
		Category = category;
		CreationTime = creationTime;
		ModificationTime = modificationTime;
	}
}