// Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} |");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" |");
    }
}

int SumOfMainDiagonalNumbers(int[,] matrix)
{
    int sumOfNumbers = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
            if(i == j) sumOfNumbers += matrix[i,j];
         }
    }
    return sumOfNumbers;
}


int[,] array2D = CreateMatrixRndInt(5, 5, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();
int sum = SumOfMainDiagonalNumbers(array2D);
Console.WriteLine($"Сумма элементов главной диагонали = {sum}");