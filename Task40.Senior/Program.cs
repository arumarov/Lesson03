// ЗАДАЧА 40. В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] array = new double[5];

void CreateArray (double[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray (double[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

double Max (double[] array)
{
    int index = 0;
    double max = array[index];
    while (index < array.Length)
    {
        if (array[index] > max)
        {
            max = array[index];
        }
        index++;
    }
    return max;    
}

double Min (double[] array)
{
    int index = 0;
    double min = array[index];
    while (index < array.Length)
    {
        if (array[index] < min)
        {
            min = array[index];
        }
        index++;
    }
    return min;    
}

CreateArray(array);
Console.Write("Заданный массив: ");
PrintArray(array);
Console.Write("\nРазница между максимальным и минимальным элементом: ");
Console.WriteLine(Max(array)-Min(array));