// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int ConvertToBin(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int dig = number % 2;
        sum = sum * 10 + dig;
        number = number / 2;
    }
    return sum;
}


int RevertNumber(int sum1)
{
    int result = 0;
    while (sum1 > 9 || sum1 > 0)
    {
        result = result + sum1 % 10;
        result = result * 10;
        sum1 = sum1 / 10;
    }
    result = result + sum1 % 10;
    return result;
}

int convertToBin = ConvertToBin(num);
int res = RevertNumber(convertToBin);
Console.WriteLine(res);