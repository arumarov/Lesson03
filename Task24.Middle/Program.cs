// ЗАДАЧА 24. Найти кубы чисел от 1 до N
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

void CreateArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = i+1;
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

void FindCube (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}" + ":" + $"{array[i]*array[i]*array[i]}" + " ");
        
    }
}

CreateArray(array);
Console.WriteLine("Заданный массив: ");
PrintArray(array);
Console.WriteLine("\nМассив с кубами чисел: ");
FindCube(array);