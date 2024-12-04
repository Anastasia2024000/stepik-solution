using System.Security.Authentication;

namespace Stepik.Trainer9;

public class StringsTrainer13
{
    /**
    * <description>
    * <see href="https://stepik.org/lesson/1279864/step/14?auth=registration&unit=1294245"/>
    * У вас есть переменная city, которая содержит входные пользовательские данные.
    * Напишите код, который подсчитывает сколько раз встречается буква в строке city,
    * отображает количество повторений в виде звездочек * и записывает результат в переменную result.
    * </description>
    * <example><para>Trainer13("Ривенделл")
         -> "р:*,и:*,в:*,е:**,н:*,д:*,л:**" </para></example>
    * <summary>
    * Находит количество повторений каждого символа в строке.
    * </summary>
    * <param name="city">Строка, по которой необходимо выполнить поиск.</param>
    * <returns>Возвращает количество повторений каждого символа в строке.</returns>
    **/
    public string FindRepeatingOfSymbols(string city)
    {
        var groupBy = city.ToLower().GroupBy(x => x,
            (c, chars) => $"{c}:{new string('*', chars.Count())}"
        );

        return string.Join(',', groupBy);
    }
}