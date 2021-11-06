// ЗАДАЧА 02. Даны 2 числа. Показать большее и меньшее число
int max (int a, int b)

{
    int max = a;
    if (b > a) 
    {
        max = b;
    }
    return max;
}

int min (int a, int b)

{
    int min = a;
    if (b < a) 
    {
        min = b;
    }
    return min;
}

int a = 250;
int b = 88;
Console.Write("Максимальное число: ");
Console.WriteLine(max(a, b));
Console.Write("Минимальное число: ");
Console.WriteLine(min(a, b));