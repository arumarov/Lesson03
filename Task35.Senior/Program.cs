// ЗАДАЧА 35. Определить, присутствует ли в заданном массиве, некоторое число
// Мое решение
// int[] array = new int[10];
// Console.Write("Задайте число от 1 до 20: " );
// int a = Convert.ToInt32(Console.ReadLine());

// void CreateArray (int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = new Random().Next(1, 20);
//     }
// }

// void PrintArray (int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// string FindNumber (int[] array)
// {
//     int count = array.Length;
//     string result = "Числа нет в массиве";
//     for (int i = 0; i < count; i++)
//     {
//         if (array[i] == a) result = "Число есть в массиве";
//     }
//     return result;
// }

// CreateArray(array);
// Console.Write("Заданный массив: ");
// PrintArray(array);
// Console.WriteLine(" ");
// Console.Write(FindNumber(array));


//Решение от преподавателя
int[] arr = new int[100];
Console.Write("Search necessary number : ");
int userNumber = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();
int i;
for (i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 100);
    Console.Write(i + ":" + arr[i] + " ");
}
for (i = 0; i < arr.Length; i++)
{
    if (arr[i] == userNumber)
    {
        Console.WriteLine($"\n We found your number. this is at position {i}");
        break;
    }
}
if (i == arr.Length)
{
    Console.WriteLine("\n Element not founded");
}