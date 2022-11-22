// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа. 

// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

// int a = number / 10;
// int b = number % 10;

// if (a > b)
// {
//     Console.WriteLine($"Из числа {number} , наибольшее цифра числа => {a}");
// }
// else
// {
//     Console.WriteLine($"Из числа {number} , наибольшее цифра числа => {b}");
// }

int MaxDigital(int number)
{
    int a = number / 10;
    int b = number % 10;
    return a > b ? a : b;
}
int rez = MaxDigital(number);

Console.WriteLine($"Из числа {number} , наибольшее цифра числа => {rez}");