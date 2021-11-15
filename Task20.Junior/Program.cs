// ЗАДАЧА 20. Ввести номер четверти, показать диапазоны для возможных координат
string Quarter(int number)
{
string result = String.Empty;
if (number==1) result = "Диапазоны координат: X>0; Y>0";
if (number==2) result = "Диапазоны координат: X<0; Y>0";
if (number==3) result = "Диапазоны координат: X<0; Y<0";
if (number==4) result = "Диапазоны координат: X>0; Y<0";
return result;
}

Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Quarter(number));