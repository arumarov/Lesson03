// // ЗАДАЧА 03. По заданному номеру дня недели вывести его название

// // Мое решение
// string[] array = {"неделя", "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};

// int i = 6;
    
// Console.WriteLine(array[i]);

// // Решение преподавателя
// int a;
// Console.Write("Введите номер дня недели: ");
// string s = Console.ReadLine();
// a = Convert.ToInt32(s);

// if(a == 1) Console.WriteLine("Понедельник");
// if(a == 2) Console.WriteLine("Вторник");
// if(a == 3) Console.WriteLine("Среда");
// if(a == 4) Console.WriteLine("Четверг");
// if(a == 5) Console.WriteLine("Пятница");
// if(a == 6) Console.WriteLine("Суббота");
// if(a == 7) Console.WriteLine("Воскресенье");

// // Решение преподавателя (улучшенный вариант)
// int a;
// Console.Write("Введите номер дня недели: ");
// string s = Console.ReadLine();

// if(s == "1") Console.WriteLine("Понедельник");
// if(s == "2") Console.WriteLine("Вторник");
// if(s == "3") Console.WriteLine("Среда");
// if(s == "4") Console.WriteLine("Четверг");
// if(s == "5") Console.WriteLine("Пятница");
// if(s == "6") Console.WriteLine("Суббота");
// if(s == "7") Console.WriteLine("Воскресенье");


// Решение преподавателя (улучшенный вариант, с оператором switch/case)
// Console.Write("Введите номер дня недели: ");
// string s = Console.ReadLine();


// switch (s)
// {
//     case "1":
//     Console.WriteLine("Понедельник");
//     break;
//     case "2":
//     Console.WriteLine("Вторник");
//     break;
//     case "3":
//     Console.WriteLine("Среда");
//     break;
//     case "4":
//     Console.WriteLine("Четверг");
//     break;
//     case "5":
//     Console.WriteLine("Пятница");
//     break;
//     case "6":
//     Console.WriteLine("Суббота");
//     break;
//     case "7":
//     Console.WriteLine("Воскресенье");
//     break;
//     default:
//     Console.WriteLine("Ошибочный ввод");
//     break;
// }


// Решение преподавателя (улучшенный вариант, с использованием массива)
Console.Write("Введите номер дня недели: ");
string s = Console.ReadLine();

string[] days = new string[7];

days[0] = "Понедельник";
days[1] = "Вторник";
days[2] = "Среда";
days[3] = "Четверг";
days[4] = "Пятница";
days[5] = "Суббота";
days[6] = "Воскресенье";
int day = Convert.ToInt32(s);

Console.WriteLine(days[day-1]);