// Задача 21. Программа проверяет пятизначное число на палиндром

string Palindrom (int a)
{
    string result = ($"{a}" + " не является палиндромом");;
    if (a/10000%10==a%10 && a/1000%10==a/10%10)
    {
        result = ($"{a}" + " является палиндромом");
    }
    return result;
}

Console.WriteLine("Введите пятизначное положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Palindrom(a));