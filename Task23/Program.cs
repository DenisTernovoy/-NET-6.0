// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

void SquareTable(int num)
{
    for (int i = 1; i < num; i++)
    {
        Console.Write($"{i * i * i}, ");
    }
    Console.Write($"{num * num * num}");
}

SquareTable(number);