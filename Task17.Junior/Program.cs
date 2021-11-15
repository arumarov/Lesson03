// ЗАДАЧА 17. По двум заданным числам проверять является ли одно квадратом другого

string Check(int a, int b)
{
    string result = "Числа A и B не являются квадратами друг друга";
    if (a == b*b) 
    {
        result = "Число B является квадратом числа A";
    }
    if (b == a*a)
    {
        result = "Число A является квадратом числа B";
    }
    return result;
}

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Check(a,b));