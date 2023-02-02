// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


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

bool CheckNum(int num, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i]) return true;
    }
    return false;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(10, -9, 9);
PrintArray(array);
Console.WriteLine();
bool result = CheckNum(number, array);
if (result) Console.WriteLine($"Да, число {number} есть в массиве.");
else Console.WriteLine($"Нет, числа {number} нет в массиве.");
