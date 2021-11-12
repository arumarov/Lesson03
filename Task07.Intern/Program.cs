// ЗАДАЧА 07. Показать числа от -N до N

// Мое решение
// int[] array = new int[11];

// int index = 0;
// int N = 5;

// while (index < 11)
// {
//     array[index] = (N - 2*N + index);
//     index++;
// }

// index = 0;

// while (index < 11)
// {
//     Console.Write(array[index] + " ");
//     index++;
// }


// Решение с семинара
Console.WriteLine("Введите число от 1 до 10:");
string s = Console.ReadLine();
int b = Convert.ToInt32(s);

for (int i=-b; i<=b; i++)
{
    Console.WriteLine(i);
}