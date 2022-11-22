//? Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//* [3, 7, 23, 12] -> 19
//* [-4, -6, 89, 6] -> 0

Console.Write("Введите кол-во элементов в массиве: ");
int el = Convert.ToInt32(Console.ReadLine());

int [] NameArray (int element)
{
    Random random = new Random();
    int [] array = new int [element];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1,10);
    }
    return array;
}

int [] array = NameArray(el);

void PrintArray(int [] arr)
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


int SumArray (int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += arr[i];
        }
    }

    return sum;
}


int sum = SumArray(array);
Console.Write($" -> {sum}");