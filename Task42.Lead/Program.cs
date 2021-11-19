// Задача 42. Определить сколько чисел больше 0 введено с клавиатуры
int[] array = new int[10];

void CreateArray (int[] array)
{
    Console.WriteLine("Введите 10 чисел, которые попадут в массив(после каждого числа нажимайте Enter): ");
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        
        array[i] = Convert.ToInt32(Console.ReadLine());
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

int Find0 (int[] array)
{
    int count = array.Length;
    int k=0;
    for (int i = 0; i < count; i++)
    {
        if (array[i]>0) k++;
    }
    return k;
}


CreateArray(array);
Console.Write("Заданный массив: ");
PrintArray(array);
Console.Write("\nКоличество чисел в массиве больше 0: ");
Console.Write(Find0(array));