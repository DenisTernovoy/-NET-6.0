// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

void ChengeMatrix(int[,] matrix)
{
    Console.WriteLine();
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                newMatrix[i, j] = matrix[j, i];
            }
        }
        Console.WriteLine("Измененная матрица:");
        PrintMatrix(newMatrix);
    } else {
        Console.WriteLine("Операция невозможна!");
    }
}

int[,] array2D = CreateMatrixRndInt(5, 5, -100, 100);
PrintMatrix(array2D);
ChengeMatrix(array2D);


