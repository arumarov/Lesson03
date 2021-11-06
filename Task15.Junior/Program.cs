// ЗАДАЧА 15. Дано число. Проверить кратно ли оно 7 и 23

string multi (int a)
{
    string result = "не кратно";
    if (a%7 == 0 && a%23 == 0) result = "кратно";
    return result;
}

int a = 162;
Console.WriteLine(multi(a));
