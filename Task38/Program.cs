//? Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

//* [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Write("Введите кол-во элементов в массиве: ");
int el = Convert.ToInt32(Console.ReadLine());

double[] NameArray(int element)
{
    Random random = new Random();
    double[] array = new double[element];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * (100 - 10) + 10, 2, MidpointRounding.ToZero);
    }
    return array;
}

double[] array = NameArray(el);

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"[{arr[i]} , ");
        }
        if (i > 0 && i < arr.Length - 1)
        {
            Console.Write($"{arr[i]} , ");
        }
        if (i > arr.Length - 2)
        {
            Console.Write($"{arr[i]}]");
        }
    }
}

PrintArray(array);


double SumArray(double[] arr)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }
    }
    double res = max - min;

    return res;
}


double res = Math.Round(SumArray(array), 2, MidpointRounding.ToZero);
Console.Write($" -> {res}");