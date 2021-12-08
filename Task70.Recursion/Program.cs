// ЗАДАЧА 70. Найти сумму цифр числа

int SumNumbers(int a)
{
    if (a!<1) return 0;
    else return ((a+1/10)%10)+SumNumbers(a/10);
}

int a = 22222;
Console.WriteLine("Сумма цифр числа " + $"{a}: " + $"{SumNumbers(a)}");