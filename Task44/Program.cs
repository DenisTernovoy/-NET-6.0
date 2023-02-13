// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int [] Func(int num)
{
    
    int[] result = new int[num];
    result[0] = 0;
    
    if (num >= 2) {
        result[1] = 1;
        for (int i = 2; i < num; i++)
        {
            result[i] = result[i-1] + result[i-2];
        }
    }
    return result;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] result = Func(7);
PrintArray(result);
