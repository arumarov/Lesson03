// ЗАДАЧА 27. Определить количество цифр в числе

// // Мое решение
// string a;
// Console.Write("Введите целое число: ");
// a = Console.ReadLine();
// Console.Write("Количество цифр в числе: ");
// Console.WriteLine(a.Length);


// Решение от преподавателя (с методом)
int CountDigit(int n)
{
    int k=0;

    while (n!=0)
    {
        k++;
        n=n/10;
    }

    return k;
}

Console.WriteLine(CountDigit(456));