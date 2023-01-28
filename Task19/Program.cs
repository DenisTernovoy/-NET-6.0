// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());


bool isPalindrome(int num)
{
    string stringNum = String.Empty;
    int temp = num;
    while (temp > 0)
    {
        int lastDigit = temp % 10;
        stringNum += Convert.ToString(lastDigit);
        temp = temp / 10;
    }

    int num_reverse = Convert.ToInt32(stringNum);
    return number == num_reverse;
}

bool result = isPalindrome(number);
if (result) Console.WriteLine("Да");
else Console.WriteLine("Нет");