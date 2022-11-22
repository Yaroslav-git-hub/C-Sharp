// Задача 22: Напишите программу, 
// котораяпринимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 6
// 3 | 18
// 4 | 64
// 5 | 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Method(number);


void Method(int num)
{
    if (number > 0)
    {
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine($"{i} | {i * i}");
        }
    }
}