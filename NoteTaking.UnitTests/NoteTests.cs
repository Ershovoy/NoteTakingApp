namespace NoteTaking.UnitTests;

using NUnit.Framework;

[TestFixture]
public class NoteTests
{
	private Note _note;

	[SetUp]
	public void InitializeNote()
	{
		_note = new Note();
	}

	[Test(Description = "The default title of the note has the correct value")]
	public void DefaultTitle_CorrectValue()
	{
		// Arrange
		var expected = "Untitled Note";

		// Act
		var actual = _note.Title;

		// Assert
		Assert.That(expected, Is.EqualTo(actual),
			"The note title by default has an incorrect value");
	}

	[Test(Description = "The default text of the note has the correct value")]
	public void DefaultText_CorrectValue()
	{
		// Arrange
		var expected = "Write your note here.";

		// Act
		var actual = _note.Text;

		// Assert
		Assert.That(expected, Is.EqualTo(actual),
			"The note text by default has an incorrect value");
	}

	[Test(Description = "The default category of the note has the correct value")]
	public void DefaultCategory_CorrectValue()
	{
		// Arrange
		var expected = NoteCategory.Undefined;

		// Act
		var actual = _note.Category;

		// Assert
		Assert.That(expected, Is.EqualTo(actual),
			"The note category by default has an incorrect value");
	}

	[Test(Description = "Note title set the correct value")]
	public void TitleSet_CorrectValue()
	{
		// Arrange
		var expected = "First Note";

		// Act
		_note.Title = "First Note";
		var actual = _note.Title;

		// Assert
		Assert.That(expected, Is.EqualTo(actual),
			"The setter of the note title set an incorrect value");
	}

	[TestCase("", "The note title must be greater than 0 characters",
		TestName = "Assigning an empty string as the title of a note")]
	[TestCase("", "The note title must be must be less than 40 characters",
		TestName = "Assigning an incorrect note title containing too many characters")]
	public void TitleSet_ArgumentException(string wrongTitle, string failureMessage)
	{
		// Assert
		Assert.Throws<ArgumentException>(() =>
		{
			// Act
			_note.Title = wrongTitle;
		}, failureMessage);
	}

	[Test(Description = "Note text set the correct value")]
	public void TextSet_CorrectValue()
	{
		// Arrange
		var expected = "Write you note here";

		// Act
		_note.Text = "Write you note here";
		var actual = _note.Text;

		// Assert
		Assert.That(expected, Is.EqualTo(actual),
			"The setter of the note text set an incorrect value");
	}

	[Test(Description = "Note category set the correct value")]
	public void CategorySet_CorrectValue()
	{
		// Arrange
		var expected = NoteCategory.Document;

		// Act
		_note.Category = NoteCategory.Document;
		var actual = _note.Category;

		// Assert
		Assert.That(expected, Is.EqualTo(actual),
			"The setter of the note category set an incorrect value");
	}

	[Test(Description = "Note constructor correct value")]
	public void NoteConstructor_CorrectValue()
	{
		// Arrange
		var note = new Note("Note title", "Note text", NoteCategory.Health);
		var expectedTitle = "Note title";
		var expectedText = "Note text";
		var expectedCategory = NoteCategory.Health;

		// Act
		var actualTitle = note.Title;
		var actualText = note.Text;
		var actualCategory = note.Category;

		// Assert
		Assert.That(expectedTitle, Is.EqualTo(actualTitle));
		Assert.That(expectedText, Is.EqualTo(actualText));
		Assert.That(expectedCategory, Is.EqualTo(actualCategory));
	}

	[Test(Description = "Note time modification change after editing title")]
	public void TitleChangeTime_ValueChanged()
	{
		// Arrange
		var note = new Note();
		var expected = note.ModificationTime;

		// Act
		note.Title = "New note title...";
		var actual = note.ModificationTime;

		// Assert
		Assert.That(expected, Is.LessThan(actual));
	}

	[Test(Description = "Note time modification change after editing text")]
	public void TextChangeTime_ValueChanged()
	{
		// Arrange
		var note = new Note();
		var expected = note.ModificationTime;

		// Act
		note.Text = "New note text...";
		var actual = note.ModificationTime;

		// Assert
		Assert.That(expected, Is.LessThan(actual));
	}

	[Test(Description = "Note time modification change after editing category")]
	public void CategoryChangeTime_ValueChanged()
	{
		// Arrange
		var note = new Note();
		var expected = note.ModificationTime;

		// Act
		note.Category = NoteCategory.Document;
		var actual = note.ModificationTime;

		// Assert
		Assert.That(expected, Is.LessThan(actual));
	}
}