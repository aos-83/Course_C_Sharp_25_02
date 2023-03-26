//  Задайте значения M и N. Напишите программу, которая выведет все
//чётные натуральные числа в промежутке от M до N с помощью рекурсии.

Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);
void ValueSet(int M, int N)
{
    if (M > N)
        return;
    if (M % 2 == 0)
    {
        Console.Write($"{ M}, ");
    }
    ValueSet(M + 1, N);

}
ValueSet(M, N);