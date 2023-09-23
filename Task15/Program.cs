// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool Weekends (int num)
{
    return num>5 && num<8;
}

Console.Write("Введите число дня недели ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Weekends(number);
Console.WriteLine(result ? "да" : "нет");