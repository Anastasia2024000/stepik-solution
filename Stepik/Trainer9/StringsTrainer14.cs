namespace Stepik.Trainer9;

public class StringsTrainer14
{
    /**
     * <description>
     * <see href="https://stepik.org/lesson/1279864/step/13?auth=registration&unit=1294245"/>
     * У вас есть переменные replace, message которые содержат входные пользовательские данные.
     * Напишите код, который заменяет в строке message слово яблоки на значение переменной replace
     * и записывает результат в переменную result.
     * </description>
     * <example><para>Trainer14("бананы", "Я люблю яблоки.")
          -> "Я люблю бананы."</para></example>
     * <summary>
     * Заменяет подстроку в строке.
     * </summary>
     * <param name="replace">Строка, по которой необходимо выполнить поиск.</param>
     * <param name="message">Строка, в которой будет производиться поиск.</param>
     * <returns>Возвращает строку message c замененной подстрокой replace.</returns>
     **/
    public string ReplaceSubstringInMessage(string replace, string message)
    {
        return message.Replace("яблоки",replace);
    }
}