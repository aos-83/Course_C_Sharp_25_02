﻿//: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

void Kvad(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine(i * i + ",");
    }
}
int x = int.Parse(Console.ReadLine()!);
Kvad(x);