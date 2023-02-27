// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите три числа : ");
string s_a = Console.ReadLine()!;
string s_b = Console.ReadLine()!;
string s_c = Console.ReadLine()!;

int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);
int max = 0;

if (a > max)
{
    max = a;
}
if (b > max) 
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("max = " + max);