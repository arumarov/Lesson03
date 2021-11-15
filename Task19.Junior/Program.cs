// ЗАДАЧА 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
string Quarter(int x, int y)
{
    string result = String.Empty;
    if (x>0 && y>0) result = "Номер четверти: 1";
    if (x<0 && y>0) result = "Номер четверти: 2";
    if (x<0 && y<0) result = "Номер четверти: 3";
    if (x>0 && y<0) result = "Номер четверти: 4";
    return result;
}

Console.Write("Введите значение x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Quarter(x,y));