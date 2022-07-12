namespace NoteTaking.UnitTests;

using NUnit.Framework;

[TestFixture]
public class NotebookTests
{
	// TODO: оформить тесты в виде блоков Arrange, Act, Assert (см. NoteTests)
	[Test(Description = "Test changing count of notes after adding/removing")]
	public void NoteCount_ValueChanged()
	{
		// TODO: почему ты уверен, что число меняется правильно? А если после Remove счетчик не уменьшился, и не уменьшился после третьего AddNote()? Тогда счетчик вернет значение 2, но это будет ошибочное значение... Логика теста неправильная
		var notebook = new Notebook();
		int expected = 2;

		notebook.AddNote(new Note());
		notebook.AddNote(new Note());
		notebook.RemoveNote(1);
		notebook.AddNote(new Note());
		int actual = notebook.NotesCount;

		Assert.That(expected, Is.EqualTo(actual));
	}

	// TODO: именование метода теста не соответствует требованиям
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

	// TODO: когда будет отдельный класс для сохранения загрузки блокнота, тесты тоже вынести в отдельный класс
	[Test(Description = "Save and load notebook test")]
	public void SaveLoadNotebookTest()
	{
		var expected = new Notebook();
		expected.AddNote(new Note("First note", "", NoteCategoryType.Default));
		expected.AddNote(new Note("Second note", "WASD", NoteCategoryType.Home));
		// TODO: абсолютные пути в программировании - это абсолютное зло! А если у разработчика нет раздела D? А если такого раздела не будет на билд-сервере (скорее всего)? Тесты упадут, хотя в самой тестируемой логике нет ошибок. Переделать на относительные пути
		// TODO: в случае тестов надо создавать подпапку Test в папке bin, откуда и запускаются юнит-тесты, и сохранять все файлы там. Еще можно разделить папки Input и Output, если надо
		expected.Save(@"D:\json.txt");

		var actual = new Notebook();
		actual.Load(@"D:\json.txt");
		// TODO: где проверка того, что загрузилось? А если метод вернул null или пустой блокнот?
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
		// TODO: сортировка меняет порядок целой коллекции, надо проверять что вся коллекция поменялась.
		notebook.SortBy(NoteCategoryType.Home);
		var actual = notebook[0];
		// TODO: почему ты этим ассертом уверен, что expected и actual - это действительно одна и та же заметка? А если это 1 и 3 заметки? Они же одной категории. Неправильная логика проверки результата
		Assert.That(expected.Category, Is.EqualTo(actual.Category));
	}
}