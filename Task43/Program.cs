// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите число b1: ");
double bFirst = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k1: ");
double kFirst = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2: ");
double bSecond = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2: ");
double kSecond = Convert.ToDouble(Console.ReadLine());

void CrossPoint(double b1, double k1, double b2, double k2)
{
    if (k2 == k1 && b2 != b1) Console.WriteLine("Прямые параллельные");
    else if(k2 == k1 && b2 == b1) Console.WriteLine("Прямые совпадают");
    else {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"({x}, {y})");
    }
}

CrossPoint(bFirst, kFirst, bSecond, kSecond);