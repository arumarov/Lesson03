//ЗАДАЧА 50. В двумерном массиве n×k заменить четные элементы на противоположные
void SetArray2D(int[,] a)
{
	for(int n=0;n<a.GetLength(0);n++)
	{
		for(int k=0;k<a.GetLength(1);k++)
		{
			a[n,k] = new Random().Next(-100,100);
		}
	}
}

void PrintArray(int[,] a)
{
	for(int n=0;n<a.GetLength(0);n++)
	{
		for(int k=0;k<a.GetLength(1);k++)
		{
			Console.Write($"{a[n,k],4}");
		}
		Console.WriteLine();
	}
}

void ChangeEven(int[,] a, int[,] b)
{
	for(int n=0;n<a.GetLength(0);n++)
	{
		for(int k=0;k<a.GetLength(1);k++)
		{
			b[n,k] = (a[n,k]*-1);
		}
	}
}

void PrintArrayB(int[,] b)
{
	for(int n=0;n<b.GetLength(0);n++)
	{
		for(int k=0;k<b.GetLength(1);k++)
		{
			Console.Write($"{b[n,k],4}");
		}
		Console.WriteLine();
	}
}

Console.WriteLine("Введите количество строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int k = Convert.ToInt32(Console.ReadLine());
int[,] a;
a = new int[n,k];
SetArray2D(a);
Console.WriteLine("Массив: ");
PrintArray(a);
int[,] b;
b = new int[n,k];
ChangeEven(a,b);
Console.WriteLine("Откорректированный массив: ");
PrintArrayB(b);