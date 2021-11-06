// ЗАДАЧА 04. Найти максимальное из трех чисел
int max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result; 
}
int arg1 = 459;
int arg2 = 356;
int arg3 = 62;

Console.WriteLine(max(arg1,arg2,arg3));