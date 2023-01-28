Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

string isSquare(int num1, int num2)
{
    if (num1 * num1 == num2) return "Да";
    else return "Нет";
}

string result = isSquare(number1, number2);
Console.WriteLine(result);