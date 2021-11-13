// ЗАДАЧА 13. Выяснить, кратно ли число заданному, если нет, вывести остаток
Console.WriteLine("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, на кратность которому проверяем предыдущее число: ");
int b = Convert.ToInt32(Console.ReadLine());

string Multiple (int a, int b)
{
    string result = String.Empty;
    if (a%b == 0) 
    {
        result = $"{a}" + " кратно " + $"{b}";
    }
    else
    {
        result = $"{a}" + " не кратно " + $"{b}" +  ", остаток равен " +  $"{a%b}";
    }
        
    return result;
}

Console.WriteLine(Multiple(a,b));