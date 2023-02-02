// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int SumNumber(int[] arr)
{
    int sumNumber = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sumNumber += arr[i];
    }
    return sumNumber;
}

int sizeArray = new Random().Next(0, 15);
int[] array = CreateArrayRndInt(sizeArray, -10, 10);
PrintArray(array);

int result = SumNumber(array);
Console.WriteLine($" -> {result}");