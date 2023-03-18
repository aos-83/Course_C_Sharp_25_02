// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] CreateArrayFromConsole(int number)
{
    int[] intArray = new int[number];
    Console.WriteLine($"введите {number} целых чисел:");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"все ошибки ввода будут заменены на 0");
    Console.ForegroundColor = ConsoleColor.White;

    for (int i = 0; i < intArray.Length; i++)
    {
        bool success = int.TryParse(Console.ReadLine(), out int num);
        intArray[i] = success ? num : 0;
    }

    return intArray;
}

int GetPositiveNumbersCount(int[] intArray)
{
    // совместим проход по массиву с его выводом на консоль.
    int counter = 0;
    foreach (int item in intArray)
    {
        if (item > 0) counter++;
        Console.Write($"{item} ");
    }

    return counter;
}

int[] intArray = CreateArrayFromConsole(10);
int counter = GetPositiveNumbersCount(intArray);

Console.WriteLine("\n");
Console.WriteLine($"количество чисел больше 0 = {counter}");
Console.WriteLine("\n");