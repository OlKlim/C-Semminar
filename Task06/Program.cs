// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введи число ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 2 == 0)
{
    Console.WriteLine($"{number1} -> да");
}
else
    Console.WriteLine($"{number1} -> нет");