// ЗАДАЧА 71. Написать программу вычисления функции Аккермана
//Мое решение
int Akkerman(int m, int n)
{
    if(m==0) return n+1;
    if(m>0 && n==0) return Akkerman(m-1,1);
    if(m>0 && n>0) return Akkerman(m-1,Akkerman(m,n-1));
    else return 0;
}

Console.WriteLine(Akkerman(0,0));