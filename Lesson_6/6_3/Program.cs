﻿// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

void Fibnch (int num)
{
    int a=0;
    int b=1;
    for (int i=0; i<num; i++)
    {
        Console.WriteLine(a+" ");
        (a,b) =(b, a+b);
    }
}
int g= int.Parse(Console.ReadLine()!);
Fibnch(g);