// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

void TakeNum(int num1)
{
        if (num1 % 7 == 0 && num1 % 23 == 0)
        Console.WriteLine("да");
    else
    {
        Console.WriteLine("нет");
    }
}
TakeNum (int.Parse(Console.ReadLine()));