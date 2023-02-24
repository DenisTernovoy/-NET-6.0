// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите натуральное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

int Ack(int num1, int num2)
{
   if (num1 == 0) {
    return (num2 + 1);
   } else if (num2 == 0) {
     return Ack(num1 - 1, 1);
    } else return Ack(num1 - 1, Ack(num1, num2 - 1));
}

int result = Ack(numberM, numberN);
Console.WriteLine($"A({numberM},{numberN}) = {result}");