﻿// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите  число:");
        string number = Console.ReadLine();
        Console.WriteLine(number.Length);
    }
}