// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumNumbers(int num1, int num2)
{
    if (num1 == num2) return num1;
    return num1 + SumNumbers(num1 + 1, num2);
   
} 

Console.WriteLine("Введите два натуральных числа через enter:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

if(m > n)
{
    int temp = n;
    n = m;
    m = temp;
}

int sumNumbers = SumNumbers(m, n);
Console.WriteLine($"Сумма чисел в промежутке от {m} до {n} = {sumNumbers}");