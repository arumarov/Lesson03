// ЗАДАЧА 49. Показать двумерный массив размером m×n заполненный вещественными числами
void SetArray2D (double[,] a)
{
    for (int m=0;m<a.GetLength(0);m++)
    {
        for (int n=0;n<a.GetLength(1);n++)
        {
            double x = new Random().Next(1,100);
            a[m,n] = (x/100);
        }
    }
}
 
void PrintArray (double[,] a)
{
    for (int m=0;m<a.GetLength(0);m++)
    {
        for (int n=0;n<a.GetLength(1);n++)
        {
            Console.Write($"{a[m,n],6}");
        }
        Console.WriteLine();
    }    
}
 
Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] a;
a = new double[m,n];
SetArray2D(a);
PrintArray(a);