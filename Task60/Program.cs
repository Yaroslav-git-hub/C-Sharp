// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (i == 0 && j == 0 && k == 0)
                {
                    matrix[i, j, k] = 10;
                    continue;
                }

                if (k != 0)
                {
                    matrix[i, j, k] = matrix[i, j, k - 1] + 1;
                    continue;
                }

                if (j != 0 && k == 0)
                {
                    matrix[i, j, k] = matrix[i, j - 1, matrix.GetLength(2) - 1] + 1;
                    continue;
                }

                if (j == 0 && k == 0)
                {
                    matrix[i, j, k] = matrix[i - 1, matrix.GetLength(1) - 1, matrix.GetLength(2) - 1] + 1;
                    continue;
                }

            }

        }
    }
    return matrix;
}


void PrintMatrixWithIndex(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

int[,,] matrix3D = CreateMatrixRndInt(4, 4, 4, 10, 99);
PrintMatrixWithIndex(matrix3D);
