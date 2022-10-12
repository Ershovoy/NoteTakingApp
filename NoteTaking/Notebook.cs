namespace NoteTaking;

/// <summary>
/// Блокнот
/// </summary>
public class Notebook
{
	// TODO: + по заданию, программа должна еще сохранять и последнюю выбранную заметку, а при запуске открывать её снова.

	// TODO: + опять лишние атрибуты у полей и свойств
	// TODO: + длинная строка
	/// <summary>
	/// Справочная заметка.
	/// </summary>
	private static readonly Note _helpNote = new Note("It's the title of this help note.",
		"Create your note by clicking on the add button in the lower left corner " +
		"or select existed one on the left box.");

	/// <summary>
	/// Массив всех заметок блокнота.
	/// </summary>
	private List<Note> _notes;

	/// <summary>
	/// Последняя открытая заметка.
	/// </summary>
	private Note _lastOpenNote;

	/// <summary>
	/// Список всех заметок блокнота.
	/// </summary>
	public List<Note> Notes
	{
		get { return _notes; }
		set { _notes = value; }
	}

	/// <summary>
	/// Последняя открытая заметка.
	/// </summary>
	public Note LastOpenNote
	{
		set { _lastOpenNote = value; }
		get { return _lastOpenNote; }
	}

	/// <summary>
	/// Получить справочную заметку.
	/// </summary>
	public Note HelpNote
	{
		get { return _helpNote; }
	}

	/// <summary>
	/// Текущее количество заметок.
	/// </summary>
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
			// TODO: + зачем здесь вызывается сортировка?
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
		LastOpenNote = note;
		SortNotesByModification();
	}

	/// <summary>
	/// Вставить список заметок в блокнот.
	/// </summary>
	/// <param name="notes">Список заметок для добавления.</param>
	/// <param name="indexPlace">Место для вставки.</param>
	public void AddRange(List<Note> notes, int indexPlace)
	{
		for (int i = 0; i < notes.Count(); i++)
		{
			_notes.Insert(indexPlace, notes[i]);
			indexPlace += 1;
		}
		if (notes.Count != 0)
		{
			LastOpenNote = notes[notes.Count - 1];
		}
		SortNotesByModification();
	}

	/// <summary>
	/// Удалить существующую заметку по её индексу.
	/// </summary>
	/// <param name="index">Индекс удаляемой заметки.</param>
	public void RemoveNote(int index)
	{
		if (_notes[index].Equals(LastOpenNote))
		{
			LastOpenNote = HelpNote;
		}
		_notes.RemoveAt(index);
		SortNotesByModification();
	}

	/// <summary>
	/// Удалить существующую заметку по ей соответственной.
	/// </summary>
	/// <param name="note">Соответствующая заметка для удаления.</param>
	public void RemoveNote(Note NoteToDelete)
	{
		for (int i = 0; i < NotesCount; i++)
		{
			if (this[i] == NoteToDelete)
			{
				RemoveNote(i);
				if (NoteToDelete == LastOpenNote)
				{
					LastOpenNote = HelpNote;
				}
			}
		}
	}

	/// <summary>
	/// Удалить все существующие заметки.
	/// </summary>
	public void Clear()
	{
		_notes.Clear();
		LastOpenNote = HelpNote;
	}

	/// <summary>
	/// Просмотреть заметку по индексу.
	/// </summary>
	/// <param name="index">Индекс заметки.</param>
	/// <returns>Заметка для просмотра.</returns>
	public Note ViewNote(int index)
	{
		LastOpenNote = _notes[index];
		return _notes[index];
	}

	/// <summary>
	/// Сортировка заметок по времени их последнего изменения.
	/// </summary>
	public void SortNotesByModification()
	{
		_notes.Sort((t1, t2) => DateTime.Compare(t2.ModificationTime, t1.ModificationTime));
	}

	/// <summary>
	/// Получить список заметок с заданной категорией.
	/// </summary>
	/// <param name="noteCategory">Категория заметки.</param>
	public List<Note> GetNotesWithCategory(NoteCategory noteCategory)
	{
		if (noteCategory == NoteCategory.Undefined)
		{
			return _notes;
		}

		// TODO: + блокнот создает экземпляры других блокнотов? Неправильно.
		// Возвращаться должен обычный список заметок, но не блокнот.
		List<Note> result = new();
		foreach (Note note in _notes)
		{
			if (note.Category == noteCategory)
			{
				result.Add(note);
			}
		}
		return result;
	}

	/// <summary>
	/// Два блокнота равны, тогда когда каждая заметка одного блокнота,
	/// равна соответствующей заметки другого блокнота.
	/// </summary>
	/// <param name="obj">Объект класса Notebook.</param>
	/// <returns>True если блокноты равны, иначе false.</returns>
	public override bool Equals(object? obj)
	{
		var other = obj as Notebook;
		if (other is null)
		{
			return false;
		}
		if (NotesCount != other.NotesCount)
		{
			return false;
		}
		for (int i = 0; i < NotesCount; i++)
		{
			if (!this[i].Equals(other[i]))
			{
				return false;
			}
		}
		return true;
	}
}