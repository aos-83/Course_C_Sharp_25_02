// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] Matrix1 = new int[m, n];
CreateArray (Matrix1);
Console.WriteLine($"Первая матрица:");
WriteArray (Matrix1);

int[,] Matrix2 = new int[n, p];
CreateArray(Matrix2);
Console.WriteLine($"Вторая матрица:");
WriteArray(Matrix2);

int[,] resultMatrix = new int[m,p];

Matrix(Matrix1, Matrix2, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void Matrix(int[,] Matrix1, int[,] Matrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Matrix1.GetLength(1); k++)
      {
        sum += Matrix1[i,k] * Matrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}