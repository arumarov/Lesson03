//ЗАДАЧА 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
 
Random rnd = new Random();
void SetArray2D (int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
             a[i,j] = rnd.Next(1,99);        
        }
    }
}
 
void PrintArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
             Console.Write($"{a[i,j],4}");        
        }
        Console.WriteLine();
    }
}
 
void ChangeArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            if (i%2==0 && j%2==0) a[i,j]=a[i,j]*a[i,j];                
        }
    }
}
 
void PrintArrayB(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            Console.Write($"{a[i,j],6}");        
        }
        Console.WriteLine();
    }
}
 
Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] a;
a = new int[m,n];
SetArray2D(a);
Console.WriteLine("Массив: ");
PrintArray(a);
ChangeArray(a);
Console.WriteLine("Откорректированный массив: ");
PrintArrayB(a);
