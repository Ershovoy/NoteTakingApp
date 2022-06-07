namespace NoteTaking.UnitTests;

using NUnit.Framework;

[TestFixture]
public class NoteTests
{
	[Test(Description = "Note title getter/setter test")]
	public void Title_CorrectValue()
	{
		var note = new Note();
		var expected = "First Note";

		note.Title = "First Note";
		var actual = note.Title;

		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "Note text getter/setter test")]
	public void Text_CorrectValue()
	{
		var note = new Note();
		var expected = "Write you note here";

		note.Text = "Write you note here";
		var actual = note.Text;

		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "Note category getter/setter test")]
	public void Category_CorrectValue()
	{
		var note = new Note();
		var expected = NoteCategoryType.Document;

		note.Category = NoteCategoryType.Document;
		var actual = note.Category;

		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "Test of Note time modification")]
	public void ModifiedTime_ValueChanged()
	{
		var note = new Note();
		var expected = note.ModifiedTime;

		note.Category = NoteCategoryType.Document;
		var actual = note.ModifiedTime;

		Assert.That(expected, Is.LessThan(actual));
	}
}