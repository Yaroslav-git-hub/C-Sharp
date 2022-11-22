// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = Method(number);
Console.Write($"Сумма цифр числа {number} -> {res}");

int Method(int a)
{
    int res = 0;
    if (a > 0)
    {
        for (int i = 0; i <= a; i++)
        {
            res = res + i;
        }
    }
    return res;
}
