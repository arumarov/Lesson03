// ЗАДАЧА 06. Выяснить является ли число чётным
string even (int a)
{
    string result = "нечетное число";
    if (a%2 == 0) result = "четное число";
    return result;
}

int a = 6;
Console.WriteLine(even(a));