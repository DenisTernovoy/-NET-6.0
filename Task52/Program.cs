// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] GetAverageColumn(int[,] matrix)
{
    double[] newArray = new double[matrix.GetLength(1)];
    double result = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        result = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
             result += matrix[j, i];
        }
        newArray[i] = Math.Round(result / matrix.GetLength(0), 1);        
    }
    return newArray;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i], 4} ");
        else Console.Write($"{arr[i], 4}");
    }
    Console.Write("]");
}


int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое столбцов:");
double[] resultArray = GetAverageColumn(array2D);
PrintArray(resultArray);