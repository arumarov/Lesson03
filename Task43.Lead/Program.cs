// ЗАДАЧА 43.Написать программу преобразования десятичного числа в двоичное
void Transformation (int number10)
{
	string number2=Convert.ToString(number10, 2);
	Console.WriteLine("В двоичной системе счисления:" + number2);
}

Console.WriteLine("Введите десятичное число: ");
int number10 = Convert.ToInt32(Console.ReadLine());
Transformation(number10);