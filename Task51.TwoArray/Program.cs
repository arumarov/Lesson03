//ЗАДАЧА 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
void SetArray2D(int[,] a)
{
	for(int m=0;m<a.GetLength(0);m++)
	{
		for(int n=0;n<a.GetLength(1);n++)
		{
			a[m,n] = m+n;
		}
	}
}

void PrintArray(int[,] a)
{
	for(int m=0;m<a.GetLength(0);m++)
	{
		for(int n=0;n<a.GetLength(1);n++)
		{
			Console.Write($"{a[m,n],4}");
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
PrintArray(a);