// ЗАДАЧА 07. Показать числа от -N до N
int[] array = new int[11];

int index = 0;
int N = 5;

while (index < 11)
{
    array[index] = (N - 2*N + index);
    index++;
}

index = 0;

while (index < 11)
{
    Console.Write(array[index] + " ");
    index++;
}