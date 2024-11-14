namespace Stepik.Trainer9;

/*У вас есть переменная title, которая содержит входные пользовательские данные.

Напишите код, который преобразует содержимое переменной title в валидный slug и записывает результат в переменную result.

Slug - это уникальная строка идентификатор, понятная человеку.

Sample Input 1:
The Hellfire Club

Sample Output 1:
the-hellfire-club

Sample Input 2:
Dear Billy

Sample Output 2:
dear-billy
*/

public class StringsTrainer1
{
    public string Trainer11(string title)
    {
        return title.ToLower().Replace(' ', '-');
        
    }

}
