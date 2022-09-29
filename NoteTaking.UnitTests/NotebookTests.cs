namespace NoteTaking.UnitTests;

using NUnit.Framework;

[TestFixture]
public class NotebookTests
{
	// TODO: + оформить тесты в виде блоков Arrange, Act, Assert (см. NoteTests)
	[Test(Description = "Test changing count of notes after adding")]
	public void NoteCount_ValueIncreased()
	{
		// TODO: + почему ты уверен, что число меняется правильно? А если после Remove счетчик не уменьшился, и не уменьшился после третьего AddNote()? Тогда счетчик вернет значение 2, но это будет ошибочное значение... Логика теста неправильная
		// Arrange
		var notebook = new Notebook();
		int expected = 2;

		// Act
		notebook.AddNote(new Note());
		notebook.AddNote(new Note());
		int actual = notebook.NotesCount;

		// Assert
		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "Test changing count of notes after adding/removing")]
	public void NoteCount_ValueDecreased()
	{
		// Arrange
		var notebook = new Notebook();
		int expected = 1;

		// Act
		notebook.AddNote(new Note());
		notebook.AddNote(new Note());
		notebook.RemoveNote(1);
		int actual = notebook.NotesCount;

		// Assert
		Assert.That(expected, Is.EqualTo(actual));
	}

	// TODO: + именование метода теста не соответствует требованиям
	[Test(Description = "Adding note to notebook test")]
	public void AddNoteTest()
	{
		// Arrange
		var notebook = new Notebook();
		var expected = new Note("First note", "WASD", NoteCategory.Home);

		// Act
		notebook.AddNote(expected);
		var actual = notebook[0];

		// Assert
		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "Notebook add range of notes test")]
	public void AddRangeTest()
	{
		// Arrange
		var expected = new Notebook();
		expected.AddNote(new Note("Test note", "", NoteCategory.Document));
		expected.AddNote(new Note("Second note", "", NoteCategory.Undefined));
		
		// Act
		var actual = new Notebook();
		List<Note> notes = expected.GetNotesWithCategory(NoteCategory.Undefined);
		actual.AddRange(notes, 0);

		// Assert
		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "Removing note from notebook test")]
	public void RemoveNoteTest()
	{
		// Arrange
		var notebook = new Notebook();
		notebook.AddNote(new Note("Second note", "WASD", NoteCategory.Home));

		// Act
		notebook.RemoveNote(0);

		// Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => { notebook[0].Title = "New title"; });
	}

	[Test(Description = "Removing note from notebook test by specifying certain note")]
	public void RemoveNoteTest2()
	{
		// Arrange
		var actual = new Notebook();
		actual.AddNote(new Note("First note", "", NoteCategory.Undefined));
		actual.AddNote(new Note("Second note", "", NoteCategory.Undefined));
		actual.AddNote(new Note("The Bible",
			"In the beginning God created the heavens and the earth.",
			NoteCategory.Document));

		var expected = new Notebook();
		List<Note> notes = actual.GetNotesWithCategory(NoteCategory.Undefined);
		expected.AddRange(notes, 0);

		actual.AddNote(new Note("Demonic note", "^&*#!)@^$&^_@#)_+!", NoteCategory.Other));
		Note noteToDelete = actual[0];

		// Act
		actual.RemoveNote(noteToDelete);

		// Assert
		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "Notebook clear notes test")]
	public void ClearTest()
	{
		// Arrange
		var notebook = new Notebook();
		notebook.AddNote(new Note("First note", "", NoteCategory.Undefined));
		notebook.AddNote(new Note("Second note", "", NoteCategory.Home));
		notebook.AddNote(new Note("Third note", "", NoteCategory.Undefined));
		int expectedNoteCount = 0;

		// Act
		notebook.Clear();
		int actualNoteCount = notebook.NotesCount;

		// Assert
		Assert.That(expectedNoteCount, Is.EqualTo(actualNoteCount));
	}

	[Test(Description = "Notebook get note property test")]
	public void GetNoteTest()
	{
		// Arrange
		var notebook = new Notebook();
		notebook.AddNote(new Note("First note", "", NoteCategory.Undefined));
		notebook.AddNote(new Note("Second note", "", NoteCategory.Home));
		notebook.AddNote(new Note("Third note", "", NoteCategory.Undefined));
		var expected = new Note("Third note", "", NoteCategory.Undefined);

		// Act
		var actual = notebook[0];

		// Assert
		Assert.That(expected.Title, Is.EqualTo(actual.Title));
		Assert.That(expected.Text, Is.EqualTo(actual.Text));
		Assert.That(expected.Category, Is.EqualTo(actual.Category));
	}

	[Test(Description = "Get notes with certain category from notebook test")]
	public void SortNotebookTest()
	{
		// Arrange
		var notebook = new Notebook();
		notebook.AddNote(new Note("First note", "", NoteCategory.Undefined));
		notebook.AddNote(new Note("Second note", "", NoteCategory.Home));
		notebook.AddNote(new Note("Third note", "", NoteCategory.Undefined));
		notebook.AddNote(new Note("Fourth note", "", NoteCategory.Home));
		notebook.AddNote(new Note("Fifth note", "", NoteCategory.Document));
		var expected1 = notebook[1];
		var expected2 = notebook[3];

		// TODO: + сортировка меняет порядок целой коллекции, надо проверять что вся коллекция поменялась.
		// Act
		var actual = notebook.GetNotesWithCategory(NoteCategory.Home);

		// Assert
		// TODO: + почему ты этим ассертом уверен, что expected и actual - это действительно одна и та же заметка? А если это 1 и 3 заметки? Они же одной категории. Неправильная логика проверки результата
		Assert.That(expected1, Is.EqualTo(actual[0]));
		Assert.That(expected2, Is.EqualTo(actual[1]));
	}
}