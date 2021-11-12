﻿// ЗАДАЧА 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] array = new int[10];

void CreateArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(1, 100);
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

int ProductNumbers (int[] array)
{
    int count = array.Length/2;
    int result = 0;
    int result1 = 0;
    for (int i = 0; i < count; i++)
    {
        result1 = (array[i]) * (array[(count * 2)-i-1]);
        result = result+result1;
    }
    return result;
}

CreateArray(array);
Console.Write("Заданный массив: ");
PrintArray(array);
Console.Write("\nСумма произведений пар чисел: ");
Console.Write(ProductNumbers(array));