// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void Binary(int num)
{
    string result = string.Empty;
    
    while (num / 2 != 0) {
        result += Convert.ToString(num % 2);
        num /= 2;
    }
    result += Convert.ToString(num);
    
    string newResult = string.Empty;
    for (int i = 0; i < result.Length; i++)
    {
        newResult += result[result.Length - 1 - i];
    }
    Console.WriteLine(newResult);
}

Binary(125);
