// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int ToExtent(int A, int B)
{
    int total = 1;
    for (int i = 1; i < B + 1; i++)
    {
        total *= A;
    }
    return total;
}

int result = ToExtent(number1, number2);
Console.WriteLine($"{number1} в степени {number2} -> {result}");