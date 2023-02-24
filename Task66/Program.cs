// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num1, int num2)
{
    if (num1 == num2) return num2;
    return num1 + SumNumbers(num1+1, num2);
}


if (numberM > numberN) {
    int result = SumNumbers(numberN, numberM);
    Console.WriteLine($"Сумма чисел между {numberN} и {numberM} -> {result}");
}
else {
    int result = SumNumbers(numberM, numberN);
    Console.WriteLine($"Сумма чисел между {numberM} и {numberN} -> {result}");
}

