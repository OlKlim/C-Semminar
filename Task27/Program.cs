// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Input(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Summa(int num)
{
    int sum = 0;
    while (num != 0)
    {
        int x = num % 10;
        num = num / 10;
        sum = sum + x;
    }
    return sum;
}

int number = Input("Введите целое число ");

Console.WriteLine($"{number} -> {Summa(number)}");