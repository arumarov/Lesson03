// ЗАДАЧА 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] array = new int[8];

void CreateArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0, 2);
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

CreateArray(array);
PrintArray(array);