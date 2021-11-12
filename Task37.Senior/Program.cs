// ЗАДАЧА 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];

void CreateArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0, 300);
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

int FindCount (int[] array)
{
    int count = array.Length;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i]>=10 && array[i]<=99) result = result+1;
    }
    return result;
}

CreateArray(array);
Console.Write("Заданный массив: ");
PrintArray(array);
Console.Write("\nКоличество элементов из отрезка [10,99]: ");
Console.Write(FindCount(array));