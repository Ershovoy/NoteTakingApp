using Newtonsoft.Json;

namespace NoteTaking;

// TODO: + сохранение и загрузка блокнота - отдельная самостоятельная задача, которая тянет за собой стороннюю библиотеку. Вынести в отдельный класс NotebookSerializer
// TODO: + класс NotebookSerializer должен определять дефолтный путь для сохранения файлов, но при этом его можно поменять через открытое свойство. Передавать путь в методы каждый раз не надо
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
		File.WriteAllText(_path, JsonConvert.SerializeObject(notebook, Formatting.Indented));
	}

	/// <summary>
	/// Загрузить блокнот.
	/// </summary>
	/// <returns>Загруженный блокнот.</returns>
	public static Notebook Load()
	{
		Notebook? notebook = JsonConvert.DeserializeObject<Notebook>(File.ReadAllText(_path));
		if(notebook == null)
		{
			return new Notebook();
		}
		return notebook;
	}
}
