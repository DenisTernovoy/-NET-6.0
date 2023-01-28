int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 → {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit)
//     Console.WriteLine($"НАибольшая цифра числа → {firstDigit}");
// else
//     Console.WriteLine($"НАибольшая цифра числа → {secondDigit}");

// int result = firstDigit > secondDigit ? firstDigit: secondDigit;
// Console.WriteLine($"НАибольшая цифра числа → {result}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"НАибольшая цифра числа → {maxDigit}");

int maxDigit1 = MaxDigit(86);
Console.WriteLine($"НАибольшая цифра числа → {maxDigit1}");

int maxDigit2 = MaxDigit(19);
Console.WriteLine($"НАибольшая цифра числа → {maxDigit2}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int result = firstDigit > secondDigit ? firstDigit: secondDigit;
    return result;
}
