// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Remainder(int num1, int num2)
{
    return num1 % num2;
}

Console.WriteLine("Введите два числа ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(number1, number2);

if (remainder == 0)
{
    Console.WriteLine($"{number1}, {number2} -> кратно");
} else
Console.WriteLine($"{number1}, {number2} -> не кратно, остаток {remainder}");

// Console.Write("Введите первое число ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ");
// int number2 = Convert.ToInt32(Console.ReadLine());

//int num = number1%number2;
// if (num == 0)
// {
//     Console.WriteLine($"{number1}, {number2} -> кратно");
// }
// else
//     Console.WriteLine($"{number1}, {number2} -> не кратно, остаток {num}");