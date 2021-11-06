// ЗАДАЧА 01. По двум заданным числам проверять является ли первое квадратом второго
string numbers (int a, int b)
{
    string result = "а^2 не равно b";
    if (a == b*b) result = "a^2 равно b";
    return result;
}

int a = 28;
int b = 5;
Console.WriteLine(numbers(a, b));
