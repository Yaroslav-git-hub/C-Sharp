


int countPostitive = 0;
Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
int[] positive = new int[m];
Console.WriteLine("Ввод чисел массива");

// Creat Array
int[] ArrayCreat(int[] arr, int size)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
int[] newarray = ArrayCreat(array, m);



// Array Possitive
int[] ArrayPossitive(int[] arraay, int size, int[] posarray)
{
    for (int i = 0; i < size; i++)
    {
        if (arraay[i] > 0)
        {
            posarray[i] += arraay[i];
        }
    }
    return posarray;
}
int[] PositveArray = ArrayPossitive(array, m, positive);


// Array Count
int countArray(int[] arr, int size, int cc)
{
    for (int i = 0; i < size; i++)
    {
        if (arr[i] > 0)
        {
            cc++;
        }
    }
    return cc;
}
int count = countArray(array, m, countPostitive);




Console.WriteLine("Массив чисел больше нуля: ");
void res(int [] pos)
{
    for (int i = 0; i < pos.Length; i++)
    {
        if (pos[i] == 0) continue;
        Console.WriteLine(pos[i]);
    }
}

res(PositveArray);

Console.WriteLine($"Количество: {count}");
