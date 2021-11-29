// ЗАДАЧА 23. Показать таблицу квадратов чисел от 1 до N
void SetArray2D(int[,] a) 
{
for(int i=0; i<1; i++)
{
    for(int j=0; j<a.GetLength(1); j++)
    {
        if (i==0 && j==0) a[i,j]=0;
        else a[i,j]=j-1; 
    }
}
for(int i=1; i<a.GetLength(0); i++)
{
    for(int j=0; j<1; j++)
    {
        a[i,j]=i; 
    }
}

for(int i=1; i<a.GetLength(0); i++)
{
   for(int j=1; j<a.GetLength(1); j++)
   {
       int temp=(i*10)+(j-1);
       if (j==1) a[i,j]=((i*10)*(i*10));
       else a[i,j]=(temp*temp); 
   }
}
}

void Print(int[,] a) 
{
for(int i=0; i<a.GetLength(0); i++)
{
   for(int j=0; j<a.GetLength(1); j++)
   {
       Console.Write($"{a[i,j],6}"); 
   }
   Console.WriteLine();
}
}

int[,] a;
a=new int[10,11]; 

SetArray2D(a);
Print(a);