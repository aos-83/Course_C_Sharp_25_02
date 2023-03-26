//  Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.
Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);
int Sum(int M, int N)
{
   if (N == 0) return 1;
    return Sum(M, N-1)+M;
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {Sum(M, N)}");