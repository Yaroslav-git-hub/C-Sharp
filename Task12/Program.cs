// 12. Напишите программу, 
// 1) которая будет принимать на вход два числа 
// 2) и выводить, является ли второе число кратным первому. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Multiple(int arg1, int arg2)
{
    return arg1 % arg2;
}  

int rez = Multiple(number1, number2);
if (rez == 0)
{
    Console.Write("кратно");
}
else
{
    Console.Write($"не кратно, остаток {rez}");
}