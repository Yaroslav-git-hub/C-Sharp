// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите количество элементов в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());


int[] NameArray(int n)
{
    int[] array = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }

    return array;
}

void PrintArray(int[] arr)
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


int[] array = NameArray(a);
PrintArray(array);