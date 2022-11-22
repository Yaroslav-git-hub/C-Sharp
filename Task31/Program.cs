// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

Console.Write("Введите количество элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный промежуток: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный промежуток: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] NameArray(int size, int a, int b)

{
    Random random = new Random();

    int[] array = new int[num];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(a, b + 1);
    }

    return array;
}

int[] array = NameArray(num, min, max);


void PrintArray(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"[{mas[i]}, ");
        }
        if (i > 0 && i < mas.Length - 1)
        {
            Console.Write($"{mas[i]}, ");
        }
        if (i > mas.Length - 2)
        {
            Console.Write($"{mas[i]}]");
        }
    }
}

PrintArray(array);


int[] GetSumPositiveNegative(int[] arr)
{
    int sumNegative = 0;
    int sumPositive = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            sumNegative += arr[i];
        }
        else
        {
            sumPositive += arr[i];
        }
    }

    return new int []{sumNegative, sumPositive};
}

int[] sum = GetSumPositiveNegative(array);


Console.WriteLine("");

Console.WriteLine($"Сумма отрицательных чисел = {sum[0]}");
Console.WriteLine($"Сумма положительных чисел = {sum[1]}");
