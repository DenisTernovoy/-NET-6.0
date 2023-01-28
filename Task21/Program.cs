// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты 1-ой точки");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты 2-ой точки");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
}

double result = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine(result);