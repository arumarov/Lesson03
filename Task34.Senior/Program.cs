// ЗАДАЧА 34. Написать программу замену элементов массива на противоположные

int[] array = new int[10];


void CreateArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(1, 10);
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

void ChangeArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = -array[i];
    }
}

void PrintArray2 (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

CreateArray(array);
Console.Write("Заданный массив: ");
PrintArray(array);
ChangeArray(array);
Console.Write("\nЗаданный массив с измененными данными: ");
PrintArray2(array);