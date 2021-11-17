// ЗАДАЧА 25. Найти сумму чисел от 1 до А
int summa(int a)
{
    int result = 0;
    result = a*(a+1)/2;
    return result;
}

Console.Write("Введите целое число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Сумма чисел от 1 до A: " + $"{summa(a)}");