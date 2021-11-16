// ЗАДАЧА 30. Показать кубы чисел, заканчивающиеся на четную цифру
int[] array = new int[10];

void CreateArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(1, 99);
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
        if ((array[i]*array[i]*array[i])%2==0) Console.Write($"{array[i]*array[i]*array[i]}" + " ");
        
    }
}


CreateArray(array);
Console.WriteLine("Заданный массив: ");
PrintArray(array);
Console.WriteLine("\nКубы чисел массива, заканчивающиеся на четную цифру: ");
FindCube(array);