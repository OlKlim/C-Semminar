// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int MinusNumber(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}

Console.Write("ВВедите число ");
int number = Convert.ToInt32(Console.ReadLine());

int result = MinusNumber(number);

if (number > 99)
{
    Console.WriteLine($"{number} -> {result}");
}
else Console.WriteLine($"{number} -> третьей цифры нет");