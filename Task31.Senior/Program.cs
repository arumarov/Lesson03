// ЗАДАЧА 31. Задать массив из 8 элементов и вывести их на экран
int[] array = {4, 8, 34, 23, 71, 96, 4, 7};

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(array);