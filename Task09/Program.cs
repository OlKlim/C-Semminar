// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10, 99] -> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// int max = firstDigit;
// if (firstDigit < secondDigit) max = secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {number} -> {max}");

// int maxDigit = firstDigit >secondDigit?firstDigit:secondDigit; //Тернарный оператор
// Console.WriteLine($"Наибольшая цифра числа {number} -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа {number} -> {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit >secondDigit?firstDigit:secondDigit;
}