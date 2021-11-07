// ЗАДАЧА 08. Показать четные числа от 1 до N
int[] array = new int[10];

int index = 0;
int N = 10;

while (index < 10)
{
    array[index] = (1 + index);
    index++;
}

index = 0;

while (index < 10)
{
    if(array[index]%2 == 0) 
    {
        Console.Write(array[index] + " ");
    }

    index++; 
}