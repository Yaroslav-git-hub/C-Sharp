// Задача 18: Напишите программу, 
// 1. которая по заданному номеру четверти,  
// 2. показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите четверть графика: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string Quarter (int Decision)
{
    if (Decision == 1) return "X > 0 и Y > 0";
    if (Decision == 2) return "X < 0 и Y > 0";
    if (Decision == 3) return "X < 0 и Y < 0";
    if (Decision == 4) return "X > 0 и Y < 0";
    return "Введен не коректный номер четверти";
}

string XY = Quarter(quarter);

Console.WriteLine(XY);