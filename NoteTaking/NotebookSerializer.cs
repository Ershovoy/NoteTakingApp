using Newtonsoft.Json;

namespace NoteTaking;

/// <summary>
/// Класс для сериализации класса Notebook.
/// </summary>
public static class NotebookSerializer
{
	/// <summary>
	/// Путь по умолчанию для сохранения/загрузки блокнота.
	/// </summary>
	private static string _defaultPath = Environment.ExpandEnvironmentVariables(@"%AppData%\NotebookData.txt");

	/// <summary>
	/// Заданный пользователем путь для сохранения/загрузки блокнота.
	/// </summary>
	private static string _path = _defaultPath;

	/// <summary>
	/// Задать/получить путь сохранения/загрузки блокнота.
	/// </summary>
	public static string Path
	{
		get { return _path; }
		set { _path = value; }
	}

	/// <summary>
	/// Сохранить блокнот.
	/// </summary>
	/// <param name="notebook">Блокнот для сохранения.</param>
	public static void Save(Notebook notebook)
	{
		// TODO: + лучше в одной строке вызывать сериализацию, а во второй запись в файл - 
		// строки короче, читаемее и проще в отладке (брейкпоинты можно поставить на каждую отдельную строчку)

		// TODO: + даже внутри класса не надо обращаться к полям напрямую - лучше через свойства. Класс тоже должен работать с полями через валидацию
		string serializedNotebook = JsonConvert.SerializeObject(notebook, Formatting.Indented);
		File.WriteAllText(Path, serializedNotebook);
	}

	/// <summary>
	/// Загрузить блокнот.
	/// </summary>
	/// <returns>Загруженный блокнот.</returns>
	public static Notebook Load()
	{
		// TODO: + а если исключения? А если файл не существует? Сделать обработку исключений, которая будет возвращать пустой блокнот
		if (!File.Exists(Path))
		{
			throw new FileNotFoundException($"Failed to load notebook from {Path}.\n" +
				$"File with notebook data didn't exist. So created one.");
		}

		string fileText = File.ReadAllText(Path);
		Notebook? notebook = JsonConvert.DeserializeObject<Notebook>(fileText);
		if (notebook == null)
		{
			return new Notebook();
		}

		return notebook;
	}
}
