// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int m = SumNumber(n);

int SumNumber(int n) 
{
    if (n > 0) return n % 10 + SumNumber(n / 10);
    else return 0;
}
Console.WriteLine($"Сумма чисел, числа {n} - равна {m}.");
