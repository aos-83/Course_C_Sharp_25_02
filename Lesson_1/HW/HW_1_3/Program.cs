// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).

Console.WriteLine("Введите число ");
string s_a = Console.ReadLine()!;
int a = int.Parse(s_a);
int remDiv = a % 2;


if (a == 0)
{
    Console.WriteLine("Четное");
}
else 
{
   Console.WriteLine("Нечетное"); 
}