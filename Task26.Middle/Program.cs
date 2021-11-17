// ЗАДАЧА 26. Возведите число А в натуральную степень B используя цикл
int degree(int a, int b)
{
    int result = a*b;
    return result;
}

Console.Write("Введите целое число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Число A в степени B: " + $"{degree(a,b)}");