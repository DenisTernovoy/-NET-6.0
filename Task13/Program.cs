Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int isThirdDigit(int num)
{
    return num / 10;
}

int result = isThirdDigit(number);
if (result > 9) Console.WriteLine(number % 10);
else Console.WriteLine("третьей цифры нет");

