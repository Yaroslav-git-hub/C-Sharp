﻿// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите натуральное число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int m1, int n1)
{
    if (m1 < n1)
    {
        Console.Write($"{m1} ");
        NaturalNumbers(m1 + 1, n1);

    }
    if (m1 > n1)
    {
        Console.Write($"{m1} ");
        NaturalNumbers(m1 - 1, n1);

    }
    if (m1 == n1)
    {
        Console.Write($"{m1}");
    }
}

NaturalNumbers(n, m);