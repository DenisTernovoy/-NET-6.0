Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

bool isSquare(int num1, int num2)
{
    return num1 * num1 == num2;
}

bool result = isSquare(number1, number2);
if (result) Console.WriteLine("Да");
else Console.WriteLine("Нет");