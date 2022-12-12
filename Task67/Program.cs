// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int SumElemNumber(int num)
{
    if (num == 0) return num;
    return num % 10 + SumElemNumber(num / 10);

} 

int sumElemNumber = SumElemNumber(number);
Console.WriteLine($"Сумма цифр числа = {sumElemNumber}");