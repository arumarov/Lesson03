// ЗАДАЧА. Создать игру "Угадай число"

Console.WriteLine("Необходимо угадать число от 1 до 100. У вас 7 попыток");
int n = new Random().Next(1,100);
int k = 7;

while (k>0)
    {
        Console.Write("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());    
        if (a > n)
        {
            Console.WriteLine("Перелет");
        }
        else if (a < n) 
        {
            Console.WriteLine("Недолет");
        }
        else if (a == n)
        {
            Console.WriteLine("УРА! Вы выиграли!"); 
            Console.Read(); 
        }
        k = k-1;
    }
Console.WriteLine("Вы проиграли");
Console.Read();