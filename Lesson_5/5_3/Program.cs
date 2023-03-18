﻿// Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
int N = 123;
int[] a = new int[N];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(0, 10);
for (int i = 0; i < a.Length; i++)
    Console.Write($"{a[i],4}");

int count = 0;
for (var i = 0; i < a.Length; i++)
{
    if (i > 10 && i < 99)
        count++;
}
Console.WriteLine();
Console.WriteLine(count);
