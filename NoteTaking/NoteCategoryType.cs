namespace NoteTaking;

/// <summary>
/// Перечисление категории заметкок.
/// </summary>
// TODO: слово Type в названии лишнее, убрать. Категория и так как правило означает ограниченный набор значений
public enum NoteCategoryType
{
    // TODO: убрать вариант Default. Варианта All тоже быть не должно в перечислении
    Default,
	Work,
	Home,
	Health,
	Sport,
	People,
	Document,
	Finance,
	Other
}