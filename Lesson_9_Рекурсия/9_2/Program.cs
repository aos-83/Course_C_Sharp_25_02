// Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.

int ValuesSet(int N)
{
    if (N==0) return 0;
    return ValuesSet(N / 10)+N % 10;
}
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(ValuesSet(num));