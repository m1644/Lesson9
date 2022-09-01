// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int start, int end)
{
    if (start > end)
    return;

    Console.Write($"{start} ");
    PrintNumbers(start + 1, end);
}

PrintNumbers(1, number);
