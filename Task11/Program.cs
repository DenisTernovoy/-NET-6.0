int number = new Random().Next(100, 1000);
Console.WriteLine($"Входящее число → {number}");

int NewNumber(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    string newstring = Convert.ToString(firstDigit) + Convert.ToString(thirdDigit);
    return Convert.ToInt32(newstring);
}

int newNumber = NewNumber(number);
Console.WriteLine($"Новое число → {newNumber}");