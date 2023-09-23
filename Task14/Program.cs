// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool MultipleOfTwoNumbers (int num, int num2, int num3)
{
return num % num2 == 0 && num % num3 == 0;
}

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = MultipleOfTwoNumbers(number, 7, 23);
Console.WriteLine(result ? "да" : "нет");