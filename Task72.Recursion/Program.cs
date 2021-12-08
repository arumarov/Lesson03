// ЗАДАЧА 72. Написать программу возведения числа А в целую степень B
int Degree(int a, int b)
{
    if (b == 0) return 1;
    else return a * Degree(a,b-1);
}

int a = 2;
int b = 4;
Console.WriteLine(Degree(a, b));