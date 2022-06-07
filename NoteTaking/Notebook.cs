﻿namespace NoteTaking;

/// <summary>
/// Блокнот
/// </summary>
public class Notebook
{
	/// <summary>
	/// Конструкторы.
	/// </summary>

	/// <summary>
	/// Конструктор по умолчанию без параметров.
	/// </summary>
	public Notebook()
	{
		_notes = new();
	}

	/// <summary>
	/// Свойства.
	/// </summary>

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
		get { return _notes[index]; }
		set { _notes[index] = value; }
	}

	/// <summary>
	/// Методы.
	/// </summary>

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

	/// <summary>
	/// Реализация.
	/// </summary>

	/// <summary>
	/// Массив всех заметок блокнота.
	/// </summary>
	private List<Note> _notes = new();
}