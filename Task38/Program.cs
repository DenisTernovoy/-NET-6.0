// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double FindMax(double[] arr)
{
    double temp = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > temp) temp = arr[i];
    }
    return temp;
}

double FindMin(double[] arr)
{
    double temp = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < temp) temp = arr[i];
    }
    return temp;
}

int sizeArray = new Random().Next(0, 15);
double[] array = CreateArrayRndDouble(sizeArray, -10, 10);
PrintArray(array);
double maxNum = FindMax(array);
double minNum = FindMin(array);

Console.WriteLine($" -> {Math.Round(maxNum - minNum, 1)}");