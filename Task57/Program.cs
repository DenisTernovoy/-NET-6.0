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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

void Repeat(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count ++;
        }
    }
    Array.Sort(array);
    Console.WriteLine("Одномерный массив:");
    PrintArray(array);

    Console.WriteLine();
    Console.WriteLine();
    int newCount = 1;
    int counter = 1;
    for (int k = 0; k < array.Length - 1; k++)
    {
        if (array[k] == array[k + 1]) newCount++;
        else {
            Console.WriteLine($"{array[k]} встречается {newCount} раз");
            newCount = 1;
            counter ++;
        }
    }
    Console.WriteLine($"{array[array.Length - 1]} встречается {newCount} раз"); 
}


int[,] array2D = CreateMatrixRndInt(3, 3, 1, 10);
Console.WriteLine("Исходный массив:");
PrintMatrix(array2D);
Console.WriteLine();
Repeat(array2D);
