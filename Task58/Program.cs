// Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void CheckMatrices(int[,] matrix, int[,] matrix1)
{
    if (matrix.GetLength(0) == matrix1.GetLength(0)
    && matrix.GetLength(1) == matrix1.GetLength(1))
    {
        TwoMatricesProduct(matrix, matrix1);
    }
    else Console.WriteLine("Невозможно найти произведение матриц");
}

int[,] TwoMatricesProduct(int[,] matrix, int[,] matrix1)
{
    int[,] twoMatricesProduct = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            twoMatricesProduct[i, j] = matrix[i, j] * matrix1[i, j];
        }
    }

    return twoMatricesProduct;
}

int[,] firstMatrix = CreateMatrixRndInt(3, 3, 0, 10);
int[,] secondMatrix = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
CheckMatrices(firstMatrix, secondMatrix);
int[,] productMatrix = TwoMatricesProduct(firstMatrix, secondMatrix);
PrintMatrix(productMatrix);