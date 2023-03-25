﻿// Задайте двумерный массив. Введите элемент, и найдите
//первое его вхождение, выведите позиции по горизонтали и
//вертикали, или напишите, что такого элемента нет.
void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
    arr[i, j] = new Random().Next(from, to);
        return arr;
}
string Example (int[,] array, int num)
{
    for (int i=1; i<array.GetLength(0); i=i+2)
    {
        for (int j=1; j<array.GetLength(0); j+=2)
        {
           if(array[i, j]==num)
           return $"{i+1} {j+1}";
        }
    }
    return "Нет";
}


int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
int num=int.Parse(Console.ReadLine()!);
string summ=Example(mass, num);
Console.WriteLine(summ);