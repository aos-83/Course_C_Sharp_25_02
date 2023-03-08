//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
int SumNum(int num)
{
    int all_sum = 1;
    for (int i = 1; i <= num; i++)
    {
        all_sum += i;
    }
    return all_sum;
}
int A = int.Parse(Console.ReadLine()!);
int result = SumNum(A);
Console.WriteLine(result);