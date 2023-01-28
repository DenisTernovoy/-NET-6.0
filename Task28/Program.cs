// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

int MultNumbers(int num) 
{
    int total = 1;
    for (int i = 2; i <= num; i++)
    {
        total *= i;
    }
    return total;
}

int multNumbers = MultNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {multNumbers}");