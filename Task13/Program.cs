// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите Трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 999)
{
    number = number / 10;
}

if (number > 99)
{
    int res = number % 10;
    Console.Write(res);
}
else
{
    Console.Write("Третьей цифры нет");
}






