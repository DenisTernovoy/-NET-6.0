Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());


int NewNumber(int num)
{
    int firstDigit = num / 10;
    int secondDigit = firstDigit % 10;
    return secondDigit;
}

int newNumber = NewNumber(number);
Console.WriteLine($"Вторая цифра → {newNumber}");