// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double nnnnnnnnnnnn = 5.093203;
// Извлечение корня!
Math.Sqrt(45);
// Округление!
double yyyyyyyyyyyyyyy = Math.Round(nnnnnnnnnnnn, 2, MidpointRounding.ToZero);

Console.WriteLine("Введите координаты точки A: ");
Console.Write("Введите X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Введите координаты точки B: ");
Console.Write("Введите X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());


double Method(double xa, double ya, double xb, double yb)
{
    double srt = Math.Sqrt((Math.Pow(xb - xa, 2)) + (Math.Pow(yb - ya, 2)));
    double res = Math.Round(srt, 2, MidpointRounding.ToZero);
    return res;
}

double res = Method(x1, y1, x2, y2);
Console.Write($"Расстояние между точками в 2D пространстве -> {res}");