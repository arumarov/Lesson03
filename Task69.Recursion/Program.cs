// ЗАДАЧА 69. Найти сумму элементов от M до N, N и M заданы

int SumElements(int m, int n)
{
    if (m>n) return 0;
    else return m+SumElements(m+1,n);
}

int m=10;
int n=15;
Console.WriteLine("Сумма элементов от " + $"{m}" + " до " + $"{n} : " + $"{SumElements(m,n)}");