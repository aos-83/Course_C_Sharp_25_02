// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

string s_a = Console.ReadLine()!;

if (s_a == "1")
{
    Console.WriteLine("пн");
}

else if (s_a == "2")
{
    Console.WriteLine("вт");
}

else if (s_a == "3")
{
    Console.WriteLine("cр");
}

else if (s_a == "4")
{
    Console.WriteLine("чт");
}

else if (s_a == "5")
{
    Console.WriteLine("пт");
}

else if (s_a == "6")
{
    Console.WriteLine("сб");
}

else if (s_a == "7")
{
    Console.WriteLine("вс");
}

else
{
    Console.WriteLine("err");
}