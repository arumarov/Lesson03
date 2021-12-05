// ЗАДАЧА 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

void ArithmeticMean(int[,] a)
{
    int temp1=0;
    int temp2=0;
    int temp3=0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (j==0) temp1=temp1+a[i,j];
            if (j==1) temp2=temp2+a[i,j];
            if (j==2) temp3=temp3+a[i,j];
        }
    }
    Console.WriteLine("Среднее арифметическое 1 столбца: " + $"{temp1/a.GetLength(1)}");
    Console.WriteLine("Среднее арифметическое 2 столбца: " + $"{temp2/a.GetLength(1)}");
    Console.WriteLine("Среднее арифметическое 3 столбца: " + $"{temp3/a.GetLength(1)}");
}

int[,] a;
a = new int[3,3];
SetArray2D(a);
PrintArray(a);
ArithmeticMean(a);