Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

bool isDevide(int num)
{
    return number % 7 == 0 & number % 23 == 0;
}

bool result = isDevide(number);
if (result) Console.WriteLine("Да");
else Console.WriteLine("Нет");


