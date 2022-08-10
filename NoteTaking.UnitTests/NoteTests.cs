namespace NoteTaking.UnitTests;

using NUnit.Framework;

[TestFixture]
public class NoteTests
{
	// TODO: + протестировал не все свойства и методы. Еще куча конструкторов, и еще в куче свойств обновляет время изменения, но тестишь его только в одном NoteCategory - надо везде. А еще проверка дефолтных значений
	[Test(Description = "Note title default value test")]
	public void DefaultTitle_CorrectValue()
	{
		// Arrange
		var note = new Note();
		var expected = "Untitled Note";

		// Act
		var actual = note.Title;

		// Assert
		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "Note text default value test")]
	public void DefaultText_CorrectValue()
	{
		// Arrange
		var note = new Note();
		var expected = "Write your note here.";

		// Act
		var actual = note.Text;

		// Assert
		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "Note category default value test")]
	public void DefaultCategory_CorrectValue()
	{
		// Arrange
		var note = new Note();
		var expected = NoteCategoryType.Default;

		// Act
		var actual = note.Category;

		// Assert
		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "Note title getter/setter test")]
	public void Title_CorrectValue()
	{
		// TODO: + оформить все юнит-тесты в виде трёх блоков как сделано ниже: Подготовка данных Arrange, вызов тестируемой функциональности Act, и проверка правильности результата Assert
		// Arrange
		var note = new Note();
		var expected = "First Note";

		// Act
		note.Title = "First Note";
		var actual = note.Title;

		// Assert
		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "Note text getter/setter test")]
	public void Text_CorrectValue()
	{
		// Arrange
		var note = new Note();
		var expected = "Write you note here";

		// Act
		note.Text = "Write you note here";
		var actual = note.Text;

		// Assert
		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "Note category getter/setter test")]
	public void Category_CorrectValue()
	{
		// Arrange
		var note = new Note();
		var expected = NoteCategoryType.Document;

		// Act
		note.Category = NoteCategoryType.Document;
		var actual = note.Category;

		// Assert
		Assert.That(expected, Is.EqualTo(actual));
	}

	[Test(Description = "Note constructor value test")]
	public void NoteConstructor_CorrectValue()
	{
		// Arrange
		var note = new Note("Note title", "Note text", NoteCategoryType.Health);
		var expectedTitle = "Note title";
		var expectedText = "Note text";
		var expectedCategory = NoteCategoryType.Health;

		// Act
		var actualTitle = note.Title;
		var actualText = note.Text;
		var actualCategory = note.Category;

		// Assert
		Assert.That(expectedTitle, Is.EqualTo(actualTitle));
		Assert.That(expectedText, Is.EqualTo(actualText));
		Assert.That(expectedCategory, Is.EqualTo(actualCategory));
	}

	[Test(Description = "Test of Note time modification change after editing title")]
	public void TitleChangeTime_ValueChanged()
	{
		// Arrange
		var note = new Note();
		var expected = note.ModifiedTime;

		// Act
		note.Title = "New note title...";
		var actual = note.ModifiedTime;

		// Assert
		Assert.That(expected, Is.LessThan(actual));
	}

	[Test(Description = "Test of Note time modification change after editing text")]
	public void TextChangeTime_ValueChanged()
	{
		// Arrange
		var note = new Note();
		var expected = note.ModifiedTime;

		// Act
		note.Text = "New note text...";
		var actual = note.ModifiedTime;

		// Assert
		Assert.That(expected, Is.LessThan(actual));
	}

	[Test(Description = "Test of Note time modification change after editing category")]
	public void CategoryChangeTime_ValueChanged()
	{
		// Arrange
		var note = new Note();
		var expected = note.ModifiedTime;

		// Act
		note.Category = NoteCategoryType.Document;
		var actual = note.ModifiedTime;

		// Assert
		Assert.That(expected, Is.LessThan(actual));
	}
}