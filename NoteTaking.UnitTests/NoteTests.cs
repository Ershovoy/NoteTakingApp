namespace NoteTaking.UnitTests;

using NUnit.Framework;

[TestFixture]
public class NoteTests
{
	// TODO: протестировал не все свойства и методы. Еще куча конструкторов, и еще в куче свойств обновляет время изменения, но тестишь его только в одном NoteCategory - надо везде. А еще проверка дефолтных значений
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

	[Test(Description = "Test of Note time modification")]
	public void ModifiedTime_ValueChanged()
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