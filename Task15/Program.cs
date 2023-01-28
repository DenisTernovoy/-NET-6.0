Console.WriteLine("Введите номер дня недели:");
int number = Convert.ToInt32(Console.ReadLine());

bool isWeekend(int num)
{
    return num == 6 | num == 7;
}

bool result = isWeekend(number);
if (result) Console.WriteLine("да");
else Console.WriteLine("нет");