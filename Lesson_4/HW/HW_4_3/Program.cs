//Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.
//Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)
void Massiv(int leght)
{
    int[] R = new int[leght];
    for (int i = 0; i < leght; i++)
    {
        R[i] =new Random().Next(8);
        Console.WriteLine(R[i]);
    }
}
Massiv(int.Parse(Console.ReadLine()!));