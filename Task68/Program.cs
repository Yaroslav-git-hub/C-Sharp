// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackerman(int m, int n)
{
    if(m == 0) return n + 1;
    if(n == 0 && m > 0)  return Ackerman(m - 1, 1);
    if(m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
    return Ackerman(m, n);
}

Console.WriteLine("Введите два натуральных числа через enter:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int ackerman = Ackerman(num1, num2);
Console.WriteLine($"A({num1}, {num2}) = {ackerman}");