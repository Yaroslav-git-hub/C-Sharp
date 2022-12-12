// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
        int i = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == 0 && j == 0) matrix[i, j] = 01;
            matrix[i,j] = matrix[i, j -1] + 1;
        }
    
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
            if (j < matrix.GetLength(1) - 1) Console.Write(" |");
        }
        Console.WriteLine(" ]");
    }
}


int[,] spiralMatrix = SpiralMatrix(4, 4, 1, 16);
PrintMatrix(spiralMatrix);