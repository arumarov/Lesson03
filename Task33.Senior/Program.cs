// ЗАДАЧА 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12];
// Console.Write("Задайте число от 1 до 20: " );
// int a = Convert.ToInt32(Console.ReadLine());

void CreateArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int SumPositive (int[] array)
{
    int count = array.Length;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i] > 0) result = result+array[i];
    }
    return result;
}

int SumNegative (int[] array)
{
    int count = array.Length;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i] < 0) result = result+array[i];
    }
    return result;
}

CreateArray(array);
Console.Write("Заданный массив: ");
PrintArray(array);
Console.Write("\n Сумма положительных элементов: ");
Console.Write(SumPositive(array));
Console.Write("\n Сумма отрицательных элементов: ");
Console.Write(SumNegative(array));