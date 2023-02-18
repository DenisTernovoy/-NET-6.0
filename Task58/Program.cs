// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    };
}

bool isMult(int[,] matrix1, int[,] matrix2)
{
    return (matrix1.GetLength(1) == matrix2.GetLength(0));
}


int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int row = matrix1.GetLength(0);
    int column = matrix2.GetLength(1);

    int[,] newMatrix = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            newMatrix[i, j] = sum;
        }
    }
    return newMatrix;
}


Console.WriteLine("Исходный массив #1:");
int[,] array2D1 = CreateMatrixRndInt(2, 3, 1, 10);
PrintMatrix(array2D1);
Console.WriteLine();
int[,] array2D2 = CreateMatrixRndInt(3, 2, 1, 10);
Console.WriteLine("Исходный массив #2:");
PrintMatrix(array2D2);
Console.WriteLine();

bool result = isMult(array2D1, array2D2);

if (result) {
    int[,] resultMatrix = MultMatrix(array2D1, array2D2);
    Console.WriteLine("Результат:");
    PrintMatrix(resultMatrix);
}
else Console.WriteLine("Невозможно найти произведение!");



