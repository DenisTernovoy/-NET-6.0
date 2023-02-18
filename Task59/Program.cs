// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[,] ChangeMatrix(int[,] matrix)
{
    int min = matrix[0, 0];
    int i_break = 0;
    int j_break = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min) {
                min = matrix[i, j];
                i_break = i;
                j_break = j;
            }
        }
    };

    Console.WriteLine($"Наименьший элемент - {matrix[i_break, j_break]}");

    int[] array = new int[(matrix.GetLength(1) - 1) * (matrix.GetLength(0) - 1)];
    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ((i == i_break) || (j == j_break)) continue;
            else {
                array[count] = matrix[i, j];
                count ++;
            }
        }
    }

    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int counter = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = array[counter];
            counter++;
        }
    }


    return newMatrix;
}


int[,] array2D = CreateMatrixRndInt(6, 7, 1, 10);
Console.WriteLine("Исходный массив:");
PrintMatrix(array2D);
int[,] newArray = ChangeMatrix(array2D);
Console.WriteLine();
Console.WriteLine("Результирующий массив:");
PrintMatrix(newArray);