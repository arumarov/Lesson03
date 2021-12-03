// ЗАДАЧА 54. В матрице чисел найти сумму элементов главной диагонали
 
Random rnd = new Random();
void SetArray2D (int[,] a)
{ 
    for(int i=0;i<a.GetLength(0);i++)
    { 
        for(int j=0;j<a.GetLength(1);j++)
        { 
            a[i,j] = rnd.Next(1,101);         
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
 
int FindSumDia(int[,] a)
{
    int temp = 0;
    for(int i=0;i<a.GetLength(0);i++)
    { 
        for(int j=0;j<a.GetLength(1);j++)
        { 
            if(i==j) temp = temp+a[i,j];     
        } 
    }
    return temp;
}
 
 
Console.WriteLine("Введите длину стороны массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;
int[,] a;
a = new int[m,n];
SetArray2D(a);
Console.WriteLine("Массив: ");
PrintArray(a);
FindSumDia(a);
Console.WriteLine("Сумма элементов главной диагонали: " + FindSumDia(a));