// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите кол-во элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный промежуток: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный промежуток: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, которое хотите найти: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");


int[] NameArray(int n, int mn, int mx)
{
    int[] array = new int[n];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(mn, mx + 1);
    }

    return array;
}

int[] array = NameArray(size, min, max);


void SearchArray(int[] mas, int num)
{
    int res = 0;

    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] == num)
        {
            res = 1;
        }
        else
        {
            res = 0;
        }
    }

    if (res == 1)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}


void Mas(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"[{arr[i]}, ");
        }
        if (i > 0 && i < arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        if (i > arr.Length - 2)
        {
            Console.Write($"{arr[i]}]");
        }
    }
}

Mas(array);
SearchArray(array, number);

