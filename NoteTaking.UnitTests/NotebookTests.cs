namespace NoteTaking.UnitTests;

using NUnit.Framework;

[TestFixture]
public class NotebookTests
{
	// TODO: + оформить тесты в виде блоков Arrange, Act, Assert (см. NoteTests)
	[Test(Description = "Test changing count of notes after adding/removing")]
	public void NoteCount_ValueChanged()
	{
		// TODO: почему ты уверен, что число меняется правильно? А если после Remove счетчик не уменьшился, и не уменьшился после третьего AddNote()? Тогда счетчик вернет значение 2, но это будет ошибочное значение... Логика теста неправильная
		// Arrange
		var notebook = new Notebook();
		int expected = 2;

		// Act
		notebook.AddNote(new Note());
		notebook.AddNote(new Note());
		notebook.RemoveNote(1);
		notebook.AddNote(new Note());
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
		var expected = new Note("First note", "WASD", NoteCategoryType.Home);

		// Act
		notebook.AddNote(expected);
		var actual = notebook[0];

		// Assert
		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "Removing note from notebook test")]
	public void RemoveNoteTest()
	{
		// Arrange
		var notebook = new Notebook();

		// Act
		notebook.AddNote(new Note("Second note", "WASD", NoteCategoryType.Home));
		notebook.RemoveNote(0);

		// Assert
		Assert.Throws<ArgumentOutOfRangeException>(() => { notebook[0].Title = "New title"; });
	}

	[Test(Description = "Sort notebook test")]
	public void SortNotebookTest()
	{
		// Arrange
		var notebook = new Notebook();

		// Act
		notebook.AddNote(new Note("First note", "", NoteCategoryType.Default));
		notebook.AddNote(new Note("Second note", "", NoteCategoryType.Home));
		notebook.AddNote(new Note("Third note", "", NoteCategoryType.Default));
		notebook.AddNote(new Note("Fourth note", "", NoteCategoryType.Home));
		notebook.AddNote(new Note("Fifth note", "", NoteCategoryType.Document));
		var expected = notebook[1];
		// TODO: сортировка меняет порядок целой коллекции, надо проверять что вся коллекция поменялась.
		notebook.SortNotesByCategory(NoteCategoryType.Home);
		var actual = notebook[0];

		// Assert
		// TODO: почему ты этим ассертом уверен, что expected и actual - это действительно одна и та же заметка? А если это 1 и 3 заметки? Они же одной категории. Неправильная логика проверки результата
		Assert.That(expected.Category, Is.EqualTo(actual.Category));
	}
}