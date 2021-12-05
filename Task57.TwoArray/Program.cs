// ЗАДАЧА 57. Написать программу упорядочивания по убыванию элементов каждой строки двумерного массива

Random rnd = new Random();
void SetArray2D(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = rnd.Next(1, 99);
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

void Descreasing(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(1) - j - 1; k++)
            {
                if (a[i, j] < a[i, j + 1])
                {
                    int temp = a[i, j];
                    a[i, j] = a[i, j + 1];
                    a[i, j + 1] = temp;
                }
            }
        }
    }
}

int[,] a;
a = new int[3, 3];
SetArray2D(a);
PrintArray(a);
Descreasing(a);
Console.WriteLine("Откорректированный массив: ");
PrintArray(a);