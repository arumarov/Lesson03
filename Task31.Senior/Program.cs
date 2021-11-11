// ЗАДАЧА 31. Задать массив из 8 элементов и вывести их на экран
// Мое решение
// int[] array = {4, 8, 34, 23, 71, 96, 4, 7};

// void PrintArray (int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// PrintArray(array);


// Решение от преподавателя
int[] a = new int[8];
Random random = new Random();
for(int i=0; i<a.Length; i++)
    a[i]=random.Next(0,100);

for(int i=0; i<a.Length; i++)
    Console.Write(a[i]+" ");