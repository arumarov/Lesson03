// ЗАДАЧА 29. Написать программу вычисления произведения чисел от 1 до N
int composition(int n)
{
    int result = 1;
    for (int i = 2; i<=n; i++)
    {
        result = result*i;
    }
    return result;
}

Console.Write("Введите целое число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Произведение чисел от 1 до N: " + $"{composition(n)}");