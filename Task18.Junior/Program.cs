// ЗАДАЧА 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

//Мое решение
// bool x = false;
// bool y = false;
// bool a = !(x || y);
// bool b = !x && !y;
// if (a == b)
// {
//     Console.WriteLine("Утверждение ¬(X ⋁ Y) = ¬X ⋀ ¬Y - истинно");
// } 
// else
// {
//     Console.WriteLine("Утверждение ¬(X ⋁ Y) = ¬X ⋀ ¬Y - ложно");
// } 

//Решение от преподавателя
bool x = false;
bool y = false;
bool f1 = !(x || y);
bool f2 = !x && !y;
Console.WriteLine(f1);
Console.WriteLine(f2);