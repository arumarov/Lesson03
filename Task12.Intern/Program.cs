// ЗАДАЧА 12. Удалить вторую цифру трёхзначного числа

int Remove(int a)
{
    Console.WriteLine("Введите трехзначное число:");
    a = Convert.ToInt32(Console.ReadLine());
    int result = ((a/100%10)*10 + a%10);
    return result;
}

Console.WriteLine(Remove(0));