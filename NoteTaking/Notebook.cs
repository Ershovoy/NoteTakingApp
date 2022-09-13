using Newtonsoft.Json;

namespace NoteTaking;

/// <summary>
/// Блокнот
/// </summary>
public class Notebook
{
    // TODO: по заданию, программа должна еще сохранять и последнюю выбранную заметку, а при запуске открывать её снова.

    // TODO: опять лишние атрибуты у полей и свойств
    /// <summary>
    /// Массив всех заметок блокнота.
    /// </summary>
    [JsonProperty]
	private List<Note> _notes;

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
		get 
		{
            // TODO: зачем здесь вызывается сортировка?
            SortNotesByModification();
			return _notes[index];
		}
		set 
		{ 
			_notes[index] = value;
			SortNotesByModification();
		}
	}

	/// <summary>
	/// Конструктор по умолчанию без параметров.
	/// </summary>
	public Notebook()
	{
		// TODO: + у тебя уже выделяется память при объявлении поля. Зачем второе выделение?
		_notes = new();
	}

	/// <summary>
	/// Добавить новую заметку в блокнот.
	/// </summary>
	/// <param name="note">Новая заметка.</param>
	public void AddNote(Note note)
	{
		_notes.Add(note);
		SortNotesByModification();
	}

	/// <summary>
	/// Удалить существующую заметку по её индексу.
	/// </summary>
	/// <param name="index">Индекс удаляемой заметки.</param>
	public void RemoveNote(int index)
	{
		_notes.RemoveAt(index);
		SortNotesByModification();
	}

	/// <summary>
	/// Сортировка заметок по времени их последнего изменения.
	/// </summary>
	public void SortNotesByModification()
	{
        _notes.Sort((t1, t2) => DateTime.Compare(t2.ModifiedTime, t1.ModifiedTime));
	}

	/// <summary>
	/// Получить список заметок с заданной категорией.
	/// </summary>
	/// <param name="noteCategory">Категория заметки.</param>
	public Notebook GetNotesWithCategory(NoteCategoryType noteCategory)
	{
		if (noteCategory == NoteCategoryType.Default)
		{
			return this;
		}

        // TODO:  блокнот создает экземпляры других блокнотов? Неправильно.
		// Возвращаться должен обычный список заметок, но не блокнот.
        Notebook result = new();
		foreach (Note note in _notes)
		{
			if (note.Category == noteCategory)
			{
				result.AddNote(note);
			}
		}
		return result;
	}
}