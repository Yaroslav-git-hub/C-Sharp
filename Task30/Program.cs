// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

Console.Write("Введите количество элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());

int [] array = new int[num];


for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);

    Console.Write(array[i] + " ");
}
