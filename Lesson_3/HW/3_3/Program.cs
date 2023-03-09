// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите любое число: ");
void Kub(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine(i * i * i + " ");
    }
}
int x = int.Parse(Console.ReadLine()!);
Kub(x);