// ЗАДАЧА 22. Найти расстояние между точками в пространстве 2D/3D

// Мое решение
// void rasstoyanie2D (int arg1, int arg2, int arg3, int arg4)
// {
//     Console.WriteLine(Math.Sqrt(Math.Pow(arg2-arg1, 2)+(Math.Pow(arg4-arg3, 2))));
// }

// void rasstoyanie3D (int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
// {
//     Console.WriteLine(Math.Sqrt(Math.Pow(arg2-arg1, 2)+(Math.Pow(arg4-arg3, 2)+(Math.Pow(arg6-arg5, 2)))));
// }

// Console.Write("Введите значение x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Расстояние в пространстве 2D: ");
// rasstoyanie2D(x1, x2, y1, y2);
// Console.Write("Расстояние в пространстве 3D: ");
// rasstoyanie3D(x1, x2, y1, y2, z1, z2);


// Решение от преподавателя
double Distance2D (double x1, double x2, double y1, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2)));
}

Console.WriteLine(Distance2D(10, 28, 2, 14));