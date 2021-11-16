// ЗАДАЧА 28. Подсчитать сумму цифр в числе

int SumDigits(int n)
{
    int b=0;

    while (n!=0)
    {
        b=b+n%10;
        n=n/10;
    }

    return b;
}

Console.WriteLine("Введите положительное целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Сумма цифр в числе: ");
Console.Write(SumDigits(n));