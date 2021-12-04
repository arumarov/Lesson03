// ЗАДАЧА 66. Показать натуральные числа от 1 до N, N задано

int ShowNumbers(int n)
{
    if (n==1) return 1;
    else return n*ShowNumbers(1);
}

for(int i=1;i<=12;i++)
{
    Console.Write(ShowNumbers(i) + " ");
}

int n=12;
ShowNumbers(n);