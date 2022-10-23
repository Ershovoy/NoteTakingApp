namespace NoteTaking.UnitTests;

using NUnit.Framework;

[TestFixture]
public class NotebookTests
{
	private Notebook _notebook;

	[SetUp]
	public void InitializeNotebook()
	{
		_notebook = new Notebook();
	}

	[Test(Description = "The value of notes count increased after adding notes")]
	public void NoteCount_ValueIncreased()
	{
		// Arrange
		int expected = 2;

		// Act
		_notebook.AddNote(new Note());
		_notebook.AddNote(new Note());
		int actual = _notebook.NotesCount;

		// Assert
		Assert.That(expected, Is.EqualTo(actual),
			"The value of notes count didn't increase after adding notes");
	}

	[Test(Description = "The value of notes count decreased after removing notes")]
	public void NoteCount_ValueDecreased()
	{
		// Arrange
		int expected = 1;

		// Act
		_notebook.AddNote(new Note());
		_notebook.AddNote(new Note());
		_notebook.RemoveNote(1);
		int actual = _notebook.NotesCount;

		// Assert
		Assert.That(expected, Is.EqualTo(actual),
			"The value of notes count didn't decreased after removing note");
	}

	[Test(Description = "The note is added to the notebook")]
	public void AddNote_CorrectValue()
	{
		// Arrange
		var expected = new Note("First note", "WASD", NoteCategory.Home);

		// Act
		_notebook.AddNote(expected);
		var actual = _notebook[0];

		// Assert
		Assert.That(expected, Is.EqualTo(actual),
			"The note wasn't added to the notebook");
	}

	[Test(Description = "Notebook add range of notes test")]
	public void AddRange_CorrectValue()
	{
		// Arrange
		var expected = new Notebook();
		expected.AddNote(new Note("First note", "", NoteCategory.Document));
		expected.AddNote(new Note("Second note", "", NoteCategory.Undefined));

		// Act
		var actual = new Notebook();
		List<Note> notes = expected.GetNotesWithCategory(NoteCategory.Undefined);
		actual.AddRange(notes, 0);

		// Assert
		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "The note from notebook is removed by index")]
	public void RemoveNote_ByIndex_ArgumentException()
	{
		// Arrange
		_notebook.AddNote(new Note("Second note", "WASD", NoteCategory.Home));

		// Act
		_notebook.RemoveNote(0);

		// Assert
		Assert.Throws<ArgumentOutOfRangeException>(() =>
		{
			_notebook[0].Title = "New title";
		}, "The note form notebook wasn't removed by index");
	}

	[Test(Description = "The note from notebook is removed by specifying certain note")]
	public void RemoveNote_ByNote_ArgumentException()
	{
		// Arrange
		Note noteToDelete = new Note("The Bible",
			"In the beginning God created the heavens and the earth.",
			NoteCategory.Document);
		_notebook.AddNote(noteToDelete);

		// Act
		_notebook.RemoveNote(noteToDelete);

		// Assert
		Assert.Throws<ArgumentOutOfRangeException>(() =>
		{
			_notebook[0].Title = "New title";
		}, "The note form notebook wasn't removed by specifying certain note");
	}

	[Test(Description = "Clear all notes from the notebook")]
	public void Clear_CorrectValue()
	{
		// Arrange
		_notebook.AddNote(new Note("First note", "", NoteCategory.Undefined));
		_notebook.AddNote(new Note("Second note", "", NoteCategory.Undefined));
		_notebook.AddNote(new Note("Third note", "", NoteCategory.Undefined));
		int expectedNoteCount = 0;

		// Act
		_notebook.Clear();
		int actualNoteCount = _notebook.NotesCount;

		// Assert
		Assert.That(expectedNoteCount, Is.EqualTo(actualNoteCount),
			"Clear method deleted not all notes from the notebook");
	}

	[Test(Description = "Get note property of the notebook return correct value")]
	public void GetNote_CorrectValue()
	{
		// Arrange
		_notebook.AddNote(new Note("First note", "", NoteCategory.Undefined));
		var expected = new Note("Second note", "", NoteCategory.Home);
		_notebook.AddNote(expected);
		_notebook.AddNote(new Note("Third note", "", NoteCategory.Undefined));

		// Act
		var actual = _notebook[1];

		// Assert
		Assert.That(expected, Is.EqualTo(actual),
			"The note getter of the notebook return an incorrect value");
	}

	[Test(Description = "Set note property of the notebook set correct value")]
	public void SetNote_ValueChanged()
	{
		// Arrange
		_notebook.AddNote(new Note("First note", "", NoteCategory.Undefined));
		_notebook.AddNote(new Note("Second note", "", NoteCategory.Home));
		var expected = new Note("Third note", "", NoteCategory.Home);

		// Act
		_notebook[0] = expected;
		var actual = _notebook[0];

		// Assert
		Assert.That(expected, Is.EqualTo(actual),
			"The note setter of the notebook set an incorrect value");
	}

	[Test(Description = "The last open note from the notebook has changed")]
	public void LastOpenNote_ValueChanged()
	{
		// Arrange
		_notebook.AddNote(new Note("First note", "", NoteCategory.Undefined));
		_notebook.AddNote(new Note("Second note", "", NoteCategory.Home));
		var expected = new Note("Third note", "", NoteCategory.Document);
		_notebook.AddNote(expected);
		_notebook.AddNote(new Note("Fourth note", "", NoteCategory.Undefined));

		// Act
		_notebook.ViewNote(1);
		var actual = _notebook.LastOpenNote;

		// Assert
		Assert.That(expected, Is.EqualTo(actual),
			"The last open note from the notebook hasn't changed");
	}

	[Test(Description = "Get all notes with certain category from the notebook")]
	public void GetNotesWithCategory_CorrectValue()
	{
		// Arrange
		_notebook.AddNote(new Note("First note", "", NoteCategory.Undefined));
		_notebook.AddNote(new Note("Second note", "", NoteCategory.Home));
		_notebook.AddNote(new Note("Third note", "", NoteCategory.Other));
		_notebook.AddNote(new Note("Fourth note", "", NoteCategory.Home));
		_notebook.AddNote(new Note("Fifth note", "", NoteCategory.Document));
		List<Note> expected = new List<Note>() { _notebook[1], _notebook[3] };

		// Act
		var actual = _notebook.GetNotesWithCategory(NoteCategory.Home);

		// Assert
		// А если это 1 и 3 заметки? Они же одной категории. Неправильная логика проверки результата
		Assert.That(expected, Is.EqualTo(actual),
			"Return an incorrect list of notes with certain category from the notebook");
	}
}