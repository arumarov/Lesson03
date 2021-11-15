// ЗАДАЧА 16. Дано число обозначающее день недели. Выяснить является ли номер выходным днём
string[] array = {"неделя", "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};

string FindDay (int a)
{
    string result = $"{array[a]}" + " - выходной день";
    if (a<=5) 
    {
        result=$"{array[a]}" + " - будний день";
    }
    return result;
}

Console.Write("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindDay(a));