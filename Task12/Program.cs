Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int Division(int num1, int num2)
{
    return num1 % num2;
}

int result = Division(number1, number2);
if (result == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"не кратно, остаток {result}");
