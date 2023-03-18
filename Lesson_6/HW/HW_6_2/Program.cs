// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 *
//x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

String GetPointOfIntersection(int k1, int k2, int b1, int b2)
{
    string str43 = "Найти точку пересечения двух прямых:";
    Console.WriteLine(str43); 
    Console.WriteLine($"y = {k1}*x + {b1}");
    Console.WriteLine($"y = {k2}*x + {b2}");

    if (k1 - k2 != 0)
    {
        float x = (float)(b2 - b1) / (float)(k1 - k2);
        float y = k1 * x + b1;

        return $"точка пересечения ({x:f1} ; {y:f1})";
    }
    else
    {
        return "прямые не пересекаются или совпадают";
    }
}

int b1 = 2, // y = k1 * x + b1
    k1 = 5,
    b2 = 4, // y = k2 * x + b2
    k2 = 9;
Console.WriteLine(GetPointOfIntersection(k1, k2, b1, b2));