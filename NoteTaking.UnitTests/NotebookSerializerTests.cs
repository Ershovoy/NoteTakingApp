namespace NoteTaking.UnitTests;

using NUnit.Framework;

[TestFixture]
public class NotebookSerializerTests
{
	[Test(Description = "Save and load notebook test")]
	public void SaveLoadNotebook_CorrectValue()
	{
		// Arrange
		var expected = new Notebook();

		// Act
		expected.AddNote(new Note("First note", "", NoteCategory.Undefined));
		expected.AddNote(new Note("Second note", "WASD", NoteCategory.Home));
		NotebookSerializer.Path = @"..\..\Tests\NotebookData.txt";
		NotebookSerializer.Save(expected);
		var actual = NotebookSerializer.Load();

		// Assert
		Assert.That(actual, Is.Not.Null);
		Assert.That(expected, Is.EqualTo(actual));

		// Teardown
		if (File.Exists(NotebookSerializer.Path))
		{
			File.Delete(NotebookSerializer.Path);
		}
	}
}