namespace Stepik.Trainer9._1;

public class StringsTrainer1
{
    /// <description>
    /// У вас есть переменная title, которая содержит входные пользовательские данные.
    /// 
    /// Напишите код, который преобразует содержимое переменной title в валидный slug и
    /// записывает результат в переменную result.
    /// </description>
    /// <example><para>Trainer11("The Hellfire Club") -> "the-hellfire-club"</para></example>
    /// <example><para>Trainer11("Dear Billy") -> "dear-billy"</para></example>
    /// <remarks>Slug - это уникальная строка идентификатор, понятная человеку.</remarks>
    /// <summary>
    /// Преобразование строки в формат Slug.
    /// </summary>
    /// <param name="title">Строка, которую необходимо преобразовать в формат Slug.</param>
    /// <returns>Строка в формате Slug</returns>
    public string Trainer11(string title)
    {
        return title.ToLower().Replace(' ', '-');
        
    }
}
