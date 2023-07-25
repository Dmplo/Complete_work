// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3м символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void ShowArray(string[] array)
{
    foreach (string el in array)
    {
        Console.WriteLine(el);
    }
}

string[] array = { "Hello", "2", "world", ":-)" };
string conditionStr = String.Empty;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) conditionStr += $"{array[i]}, ";
}
if (conditionStr.Length > 0)
{
    char[] separators = new char[] { ' ', ',' };
    string[] subsArr = conditionStr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    ShowArray(subsArr);
}
else
{
    System.Console.WriteLine("[]");
}

