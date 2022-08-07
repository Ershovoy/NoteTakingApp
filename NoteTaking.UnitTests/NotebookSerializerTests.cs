namespace NoteTaking.UnitTests;

using NUnit.Framework;

[TestFixture]
public class NotebookSerializerTests
{
	// TODO: + когда будет отдельный класс для сохранения загрузки блокнота, тесты тоже вынести в отдельный класс
	[Test(Description = "Save and load notebook test")]
	public void SaveLoadNotebookTest()
	{
		// Arrange
		var expected = new Notebook();

		// Act
		expected.AddNote(new Note("First note", "", NoteCategoryType.Default));
		expected.AddNote(new Note("Second note", "WASD", NoteCategoryType.Home));
		// TODO: + абсолютные пути в программировании - это абсолютное зло! А если у разработчика нет раздела D? А если такого раздела не будет на билд-сервере (скорее всего)? Тесты упадут, хотя в самой тестируемой логике нет ошибок. Переделать на относительные пути
		// TODO: + в случае тестов надо создавать подпапку Test в папке bin, откуда и запускаются юнит-тесты, и сохранять все файлы там. Еще можно разделить папки Input и Output, если надо
		NotebookSerializer.Path = @"..\..\Tests\NotebookData.txt";
		NotebookSerializer.Save(expected);
		var actual = NotebookSerializer.Load();
		NotebookSerializer.Path = @"..\..\Tests\NotebookData2.txt";
		NotebookSerializer.Save(actual);
		// Assert
		// TODO: + где проверка того, что загрузилось? А если метод вернул null или пустой блокнот?
		//Assert.That(expected.NotesCount, Is.EqualTo(actual.NotesCount));
		//Assert.That(expected, Is.EqualTo(actual));
		Assert.That(expected[1], Is.EqualTo(actual[1]));
	}
}