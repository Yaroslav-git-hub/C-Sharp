//? Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

//! [345, 897, 568, 234] -> 2

Console.Write("Введите кол-во элементов в массиве: ");
int el = Convert.ToInt32(Console.ReadLine());


Random random = new Random();

int[] NameArray(int element)
{
    int[] array = new int[el];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100,1000);

    }
    return array;
}

int [] array = NameArray(el);

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

PrintArray(array);


int SearchNumber (int [] arr)
{
    int count = 0;
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        res = arr[i] % 2;
        if (res == 0)
        {
            count++;
        }
    }

    return count;
}

int res = SearchNumber(array);

Console.Write($" -> {res}");