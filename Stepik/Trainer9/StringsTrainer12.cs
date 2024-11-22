namespace Stepik.Trainer9;

public class StringsTrainer12
{
    /**
     * <description> 
     * <see href="https://stepik.org/lesson/1279864/step/12?auth=registration&amp;unit=1294245"/>
     * У вас есть переменные search, message которые содержат входные пользовательские данные.
     *
     *  Напишите код, который проверяет, содержит ли строка в переменной message строку из переменной search и
     *  записывает логический результат в переменную result.
     * </description>
     * <example><para>Trainer12("одежду", "Учитесь выбирать свои мысли, как выбираете в шкафу одежду каждый день.")
          -> true</para></example>
     * <example><para>Trainer12("приставку", "Учитесь выбирать свои мысли, как выбираете в шкафу одежду каждый день.")
         -> false</para></example>
     * <summary>
     * Проверяет наличие одной строки в другой строке.
     * </summary>
     * <param name="search">Строка, по которой необходимо выполнить поиск.</param>
     * <param name="message">Строка, в которой будет производиться поиск.</param>
     * <returns>Наличие или отсутствие подстроки search в строке message.</returns>
     **/
    public bool IsSearchContainsInMessage(string search, string message)
    {
        return message.Contains(search);
    }
}