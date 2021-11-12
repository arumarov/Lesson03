// ЗАДАЧА 35. Определить, присутствует ли в заданном массиве, некоторое число
int[] array = new int[10];
Console.Write("Задайте число от 1 до 20: " );
int a = Convert.ToInt32(Console.ReadLine());

void CreateArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(1, 20);
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

string FindNumber (int[] array)
{
    int count = array.Length;
    string result = "Числа нет в массиве";
    for (int i = 0; i < count; i++)
    {
        if (array[i] == a) result = "Число есть в массиве";
    }
    return result;
}

CreateArray(array);
Console.Write("Заданный массив: ");
PrintArray(array);
Console.WriteLine(" ");
Console.Write(FindNumber(array));