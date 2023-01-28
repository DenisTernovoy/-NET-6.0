int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 → {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
    Console.WriteLine($"НАибольшая цифра числа → {firstDigit}");
else
    Console.WriteLine($"НАибольшая цифра числа → {secondDigit}");

int result = firstDigit > secondDigit ? firstDigit: secondDigit;
Console.WriteLine($"НАибольшая цифра числа → {result}");