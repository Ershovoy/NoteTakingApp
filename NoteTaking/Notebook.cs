using Newtonsoft.Json;

namespace NoteTaking;

/// <summary>
/// Блокнот
/// </summary>
public class Notebook
{
	/// <summary>
	/// Массив всех заметок блокнота.
	/// </summary>
	[JsonProperty]
	private List<Note> _notes = new();

	/// <summary>
	/// Текущее количество заметок.
	/// </summary>
	[JsonIgnore]
	public int NotesCount
	{
		get { return _notes.Count; }
	}

	/// <summary>
	/// Получить заметку по индексу её индексу в массиве.
	/// </summary>
	/// <param name="index">Индекс заметки.</param>
	/// <returns>Заметка по заданному индексу.</returns>
	public Note this[int index]
	{
		get { return _notes[index]; }
		set { _notes[index] = value; }
	}

	/// <summary>
	/// Конструктор по умолчанию без параметров.
	/// </summary>
	public Notebook()
	{
		// TODO: у тебя уже выделяется память при объявлении поля. Зачем второе выделение?
		_notes = new();
	}

	/// <summary>
	/// Добавить новую заметку в блокнот.
	/// </summary>
	/// <param name="note">Новая заметка.</param>
	public void AddNote(Note note)
	{
		_notes.Add(note);
	}

	/// <summary>
	/// Удалить существующую заметку по её индексу.
	/// </summary>
	/// <param name="index">Индекс удаляемой заметки.</param>
	public void RemoveNote(int index)
	{
		_notes.RemoveAt(index);
	}

	// TODO: + xml-комментарии у всех членов класса
	// TODO: + не очевидное название.
	/// <summary>
	/// Сортировать заметки по заданной категории.
	/// </summary>
	/// <param name="noteCategory">Категория заметки.</param>
	public void SortNotesByCategory(NoteCategoryType noteCategory)
	{
		_notes.Sort((x, y) =>
		{
			return x.Category.CompareTo(y.Category);
		});
		// TODO: зачем дважды вызывается сортировка?
		_notes.Sort((x, y) =>
		{
			return y.Category.CompareTo(noteCategory);
		});
	}
}