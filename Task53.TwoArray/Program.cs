// ЗАДАЧА 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
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
 
string FindArray(int[,] a)
{ 
    string result = ("Такого числа в массиве нет");
    Console.WriteLine("Введите целое число от 1 до 100: ");
    int temp = Convert.ToInt32(Console.ReadLine());
    for(int i=0;i<a.GetLength(0);i++)
    { 
        for(int j=0;j<a.GetLength(1);j++)
        { 
            if (a[i,j]==temp)
            {
                result = ("Число " + $"{temp}" + " находится в массиве в " + $"{i+1}" + " строке, в " + $"{j+1}" + " столбце");  
            }                
        } 
    }
    return result;
}
 
Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] a;
a = new int[m,n];
SetArray2D(a);
Console.WriteLine(FindArray(a));
Console.WriteLine("Массив: ");
PrintArray(a);