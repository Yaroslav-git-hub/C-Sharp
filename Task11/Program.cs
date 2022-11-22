// 11. Напишите программу, 
// 1) которая выводит случайное трёхзначное число 
// 2) и удаляет вторую цифру этого числа. 

// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DelTwoNumber(int arg)
{
    if (arg > 100 && arg < 1000)
    {
        int a = arg / 100;
        int b = arg % 10;
        return a * 10 + b;
    }
    else{
        return 0;
    }

}

int rez = DelTwoNumber(number);
if (rez == 0)
{
    Console.Write($"Мы не получили результат так как число - {number}, не трёхзначное :(");
}
else
{
    Console.Write($"Мы получили двухзначное число {rez} из {number}");
}
