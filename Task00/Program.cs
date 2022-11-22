// Напишите программу, которая на вход
// 1. На вход принимает число и 
// 2. Выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int squar = number * number;
Console.WriteLine($"Квадрат числа {number} = {squar}");


