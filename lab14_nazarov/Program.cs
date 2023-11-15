//Средний уровень, Вариант 23

using System.Text;

Console.Write("Введите строку: ");
string str = Console.ReadLine();

StringBuilder result = new StringBuilder();

for (int i = 0; i < str.Length; i++)
{
    result.Append(str[i]);
    result.Append((" = " + (int)str[i]).ToString() + " ");
}

Console.WriteLine(result);