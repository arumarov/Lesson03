// ЗАДАЧА 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool x = false;
bool y = false;
bool a = !(x || y);
bool b = !x && !y;
if (a == b)
{
    Console.WriteLine("Утверждение ¬(X ⋁ Y) = ¬X ⋀ ¬Y - истинно");
} 
else
{
    Console.WriteLine("Утверждение ¬(X ⋁ Y) = ¬X ⋀ ¬Y - ложно");
} 