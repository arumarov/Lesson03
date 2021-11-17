// ЗАДАЧА 45. Показать числа Фибоначчи
Console.Write("Сколько чисел Фибоначчи вывести в терминал: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
array[0] = 1;
array[1] = 1;
Console.Write($"{array[0]}" + " " + $"{array[1]}"+ " ");

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 2; i < count; i++)
    {
        
        array[i] = array[i-1]+array[i-2];
        Console.Write($"{array[i]} ");
    }

}

PrintArray(array);