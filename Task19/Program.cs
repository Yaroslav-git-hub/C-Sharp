// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

string additionallyNumber(int n)
{
    int res = 0;
    if (n > 9999 && n < 100000)
    {
        int a = n / 10000;
        int b = n / 1000 % 10;
        int c = n / 100 % 10;
        int d = n / 10 % 10;
        int e = n % 10;

        res = e * 10000 + d * 1000 + c * 100 + b * 10 + a;
    }
    if (n == res)
    {
        return "Да";
    }
    else
    {
        return "Нет";
    }
}

string result = additionallyNumber(Number);

Console.Write(result);
