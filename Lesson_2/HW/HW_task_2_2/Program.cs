// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int Number = new Random().Next(100, 1000);
int NewNumber = 0;

int NumberRem()
{
    NewNumber = Number / 100 * 10 + Number % 10;
    return NewNumber;
}

NumberRem();
Console.WriteLine($"Если из числа {Number} удалить вторую цифру, получится число {NewNumber}");
