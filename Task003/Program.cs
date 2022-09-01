// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

Console.Write("Введите число A: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
double b = Convert.ToInt32(Console.ReadLine());

double result = Degree(a, b); 

double Degree(double a, double b)
{
    if (b > 1) return a * Degree(a, b-1);
    return a;
}
Console.WriteLine($"Число {a} в степени {b} - равно {result}.");
