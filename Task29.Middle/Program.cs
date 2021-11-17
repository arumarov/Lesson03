// ЗАДАЧА 29. Написать программу вычисления произведения чисел от 1 до N
int composition(int n)
{
    int result = 0;
    for (int i = 1; i<n; i++)
    {
        result = i*n;
    }
    return result;
}

Console.Write("Введите целое число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Произведение чисел от 1 до N: " + $"{composition(n)}");