// ЗАДАЧА 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int FindNumber(int a)
{
    int b=(a%10);
    int c=(a/10%10);
    int result=b;
    if (c > b) result = c;
    return result;
}

Console.WriteLine("Случайное число от 10 до 99: ");
int b = Convert.ToInt32(new Random().Next(10,99));
Console.WriteLine(b);
Console.WriteLine("Наибольшая цифра числа: ");
Console.WriteLine(FindNumber(b));