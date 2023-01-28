﻿Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

int quarter = Quarter(x, y);
string result = quarter > 0 
            ? $"Указанные координаты соответствуют четверти → {quarter}"
            : "Введены некорректные координаты";

Console.WriteLine(result);
