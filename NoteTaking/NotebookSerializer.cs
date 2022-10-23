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
		string serializedNotebook = JsonConvert.SerializeObject(notebook, Formatting.Indented);
		File.WriteAllText(Path, serializedNotebook);
	}

	/// <summary>
	/// Загрузить блокнот.
	/// </summary>
	/// <returns>Загруженный блокнот.</returns>
	public static Notebook Load()
	{
		if (!File.Exists(Path))
		{
			Notebook result = new Notebook();
			result.LastOpenNote = result.HelpNote;
			return result;
		}

		string fileText = File.ReadAllText(Path);
		Notebook? notebook = JsonConvert.DeserializeObject<Notebook>(fileText);
		if (notebook is null)
		{
			return new Notebook();
		}

		return notebook;
	}
}
