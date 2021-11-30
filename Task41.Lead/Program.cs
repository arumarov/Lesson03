// ЗАДАЧА 41. Выяснить являются ли три числа сторонами треугольника
void Triangle (int a, int b, int c)
{
    if ((a+b)>c && (a+c)>b && (b+c)>a) Console.WriteLine("Числа являются сторонами треугольника");
    else Console.WriteLine("Числа не являются сторонами треугольника");
}
 
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int c = Convert.ToInt32(Console.ReadLine());
Triangle(a,b,c);