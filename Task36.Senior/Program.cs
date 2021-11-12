// ЗАДАЧА 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] array = new int[10];

void CreateArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int CountEven (int[] array)
{
    int count = array.Length;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i]%2==0) result = result+1;
    }
    return result;
}

int CountUneven (int[] array)
{
    int count = array.Length;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i]%2>0) result = result+1;
    }
    return result;
}

CreateArray(array);
Console.Write("Заданный массив: ");
PrintArray(array);
Console.Write("\n Количество четных элементов: ");
Console.Write(CountEven(array));
Console.Write("\n Количество нечетных элементов: ");
Console.Write(CountUneven(array));