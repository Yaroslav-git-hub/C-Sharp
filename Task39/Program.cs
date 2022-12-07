// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]




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


void ArrayReverse(int [] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int a = arr[i];
        array[i] = array[array.Length - 1 -i];
        array[array.Length - 1 -i] = a;
    }
}

PrintArray(array);
ArrayReverse(array);
PrintArray(array);