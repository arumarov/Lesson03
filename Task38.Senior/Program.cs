// ЗАДАЧА 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] array = new int[10];

void CreateArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0, 100);
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

int SumUneven (int[] array)
{
    int count = array.Length;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        if (i%2>0) result = result+array[i];
    }
    return result;
}

CreateArray(array);
Console.Write("Заданный массив: ");
PrintArray(array);
Console.Write("\nCумма чисел, стоящих на нечетной позиции: ");
Console.Write(SumUneven(array));