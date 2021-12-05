// ЗАДАЧА 56. Написать программу, которая обменивает элементы первой строки и последней строки

Random rnd = new Random();
void SetArray2D(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++) 
        {
            a[i,j] = rnd.Next(1, 99);
        }
    }
}

void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{a[i, j],4}");
        }
        Console.WriteLine();
    }
}

void ChangeLinesArray2D(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++) 
        {
            if (i==0) 
            {
                int temp=a[a.GetLength(0)-1,j];
                int temp1=a[i,j];
                a[i,j] = temp;
                a[a.GetLength(0)-1,j] = temp1;
            }
            else a[i,j]=a[i,j];
        }
    }
}


int[,] a;
a = new int[5,5];
SetArray2D(a);
PrintArray(a);
ChangeLinesArray2D(a);
Console.WriteLine("Откорректированный массив: ");
PrintArray(a);