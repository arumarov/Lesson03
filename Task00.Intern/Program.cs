// // ЗАДАЧА 00. Вывести квадрат числа
 
// // Простое решение задачи
// int a = 5;
// Console.WriteLine(a*a);



// // Решение при помощи метода
// int Square (int x)
// {
//     return (x*x);
// }

// int a = 5;
// Console.WriteLine(Square(a));

// // Решение от преподавателя
// Console.WriteLine(Math.Pow(5,2));


// // Второе решение от преподавателя
// double a = 5;
// Console.WriteLine(Math.Pow(a,2));

// Третье решение от преподавателя (ввод с клавиатуры)
double a;
string s = Console.ReadLine();
a = Convert.ToInt32(s);
Console.WriteLine(Math.Pow(a,2));