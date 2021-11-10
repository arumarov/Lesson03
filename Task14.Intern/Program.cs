// ЗАДАЧА 14. Найти третью цифру числа или сообщить, что её нет

int Find3(int a)
{
    int result;
    Console.WriteLine("Введите трехзначное число:");
    a = Convert.ToInt32(Console.ReadLine());
    if (a < 100) result = -1;
    else result = (a%10);
    return result;
}

Console.WriteLine(Find3(0));