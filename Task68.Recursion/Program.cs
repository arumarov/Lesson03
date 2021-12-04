// ЗАДАЧА 68. Показать натуральные числа от M до N, N и M заданы

int ShowNumbers(int m)
{
    int n=20;
    if (m<=n) return m;
    else return ShowNumbers(m);
}

for(int i=10;i<=20;i++)
{
    Console.Write(ShowNumbers(i) + " ");
}

int m=20;
ShowNumbers(m);