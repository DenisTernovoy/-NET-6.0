// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] Array(int size)
{
    int[] arr = new int[size]; // 0, 1, 2, 3, 4, 5, 6, 7
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
        Console.Write($"{array[array.Length-1]}");

    Console.Write(" -> [");   

    for (int j = 0; j < array.Length-1; j++)
    {
        Console.Write($"{array[j]}, ");
    }
        Console.Write($"{array[array.Length-1]}");

    Console.Write("]");   
}


int[] resultArray = Array(8);
PrintArray(resultArray);