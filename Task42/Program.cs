// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

int DecToBaseNumber(int num, int baseNum)
{
    int res = 0;
    int mult = 1;
    while (num > 0)
    {
        res += num % baseNum * mult;
        num /= baseNum;
        mult *= 10;
    }
    return res;
}

Console.Write("Введите целое число : ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите основание системы счисления : ");
int baseNumber = Convert.ToInt32(Console.ReadLine());

int result = DecToBaseNumber(number, baseNumber);
Console.Write($"{number} -> {result}");