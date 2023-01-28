Console.WriteLine("Введите номер четверти:");
int qn = Convert.ToInt32(Console.ReadLine());

string Quarter(int q)
{
    if (q == 1) return ("x > 0 and y > 0");
    if (q == 2) return ("x < 0 and y > 0");
    if (q == 3) return ("x < 0 and y < 0");
    if (q == 4) return ("x > 0 and y < 0");
    return "Введите корректные данные!";
}

string result = Quarter(qn);
Console.WriteLine(result);
