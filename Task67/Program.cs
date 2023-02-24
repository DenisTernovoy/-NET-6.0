// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

void SumNumbers(int num)
{
    if (num == 0) return;
    int ld = num % 10;
    sum += ld;
    num /= 10;
    SumNumbers(num);
}

SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number} -> {sum}");