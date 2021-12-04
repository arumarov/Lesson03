// ЗАДАЧА 67. Показать натуральные числа от N до 1, N задано

int ShowNumbers(int n)
{
    if (n>1) return n*ShowNumbers(1);
    else return 1;
}

for(int i=15;i>=1;i--)
{
    Console.Write(ShowNumbers(i) + " ");
}

int n=15;
ShowNumbers(n);