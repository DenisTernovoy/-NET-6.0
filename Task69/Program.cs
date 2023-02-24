// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите натуральное число A:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число B:");
int numberB = Convert.ToInt32(Console.ReadLine());
int count = 0;

int MultNum(int num1, int num2)
{
    if (num2 == 0) return 1;
    return num1 * MultNum(num1, num2 - 1);
}

int result = MultNum(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} -> {result}");