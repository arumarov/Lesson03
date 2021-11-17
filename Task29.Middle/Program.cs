// ЗАДАЧА 29. Написать программу вычисления произведения чисел от 1 до N

//Мое решение
// int composition(int n)
// {
//     int result = 1;
//     for (int i = 2; i<=n; i++)
//     {
//         result = result*i;
//     }
//     return result;
// }

// Console.Write("Введите целое число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Произведение чисел от 1 до N: " + $"{composition(n)}");

//Решение от преподавателя

// ulong F=1; // расширяем, чтобы не было переполнения
double F=1;
for(int N=1; N<25; N++) //проверяем, до какого числа программа будет выдавать корректные значения (пока не произойдет переполнение)
{
    F=1;
for(uint i=1; i<=N; i++)
{
    F=F*i;
}
Console.WriteLine("N="+N+"F="+F);
}