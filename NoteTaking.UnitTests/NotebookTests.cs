namespace NoteTaking.UnitTests;

using NUnit.Framework;

[TestFixture]
public class NotebookTests
{
	[Test(Description = "Test changing count of notes after adding/removing")]
	public void NoteCount_ValueChanged()
	{
		var notebook = new Notebook();
		int expected = 2;

		notebook.AddNote(new Note());
		notebook.AddNote(new Note());
		notebook.RemoveNote(1);
		notebook.AddNote(new Note());
		int actual = notebook.NotesCount;

		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "Adding note test")]
	public void AddNoteTest()
	{
		var notebook = new Notebook();
		var expected = new Note("First note", "WASD", NoteCategoryType.Home);
		notebook.AddNote(expected);
		var actual = notebook[0];

		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "Removing note test")]
	public void RemoveNoteTest()
	{
		var notebook = new Notebook();

		notebook.AddNote(new Note("Second note", "WASD", NoteCategoryType.Home));
		notebook.RemoveNote(0);

		Assert.Throws<ArgumentOutOfRangeException>(() => { notebook[0].Title = "New title"; });
	}

	[Test(Description = "Sort notebook test")]
	public void SortNotebookTest()
	{
		var notebook = new Notebook();
		notebook.AddNote(new Note("First note", "", NoteCategoryType.Default));
		notebook.AddNote(new Note("Second note", "", NoteCategoryType.Home));
		notebook.AddNote(new Note("Third note", "", NoteCategoryType.Default));
		notebook.AddNote(new Note("Fourth note", "", NoteCategoryType.Home));
		notebook.AddNote(new Note("Fifth note", "", NoteCategoryType.Document));
		var expected = notebook[1];
		
		notebook.SortBy(NoteCategoryType.Home);
		var actual = notebook[0];
		Assert.That(expected.Category, Is.EqualTo(actual.Category));
	}
}
