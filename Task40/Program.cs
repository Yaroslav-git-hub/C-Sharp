// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool ExistTriangle(int number1, int number2, int number3)
{
    bool b = number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2;
    return b;
   
}

bool existTriangle = ExistTriangle(num1, num2, num3);
Console.WriteLine(existTriangle);