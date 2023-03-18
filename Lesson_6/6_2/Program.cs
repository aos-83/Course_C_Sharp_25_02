// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string Binary(int num)
{
    string res = "";
    while (num > 0)
    {
        res = num % 2 + res;
        num/= 2;
    }
    return res;
}
int n= int.Parse(Console.ReadLine()!);
string result = Binary(n);
Console.WriteLine(result);