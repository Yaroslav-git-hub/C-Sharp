// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Write("Введите кол-во элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный промежуток: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный промежуток: ");
int max = Convert.ToInt32(Console.ReadLine());
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




int[] Permutation(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }

    return arr;
}

int [] masive = Permutation(array);




void mas(int[] arr)
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

void PrintArray(int[] rty)
{
    for (int i = 0; i < rty.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"[{rty[i]}, ");
        }
        if (i > 0 && i < rty.Length - 1)
        {
            Console.Write($"{rty[i]}, ");
        }
        if (i > rty.Length - 2)
        {
            Console.Write($"{rty[i]}]");
        }
    }
}



mas(array);
Console.Write(" -> ");
PrintArray(masive);
