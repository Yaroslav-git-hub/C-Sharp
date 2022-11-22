// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите коордианты для нахождения расстояние между ними в 3D пространстве: ");
Console.WriteLine("");

Console.WriteLine("Введите A: ");
Console.Write("Введите координаты X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите B: ");
Console.Write("Введите координаты X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine("");
Console.Write($"Растояние между точками в 3D пространстве -> {res}");