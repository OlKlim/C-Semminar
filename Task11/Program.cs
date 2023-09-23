// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int NewDigit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    return firstDigit * 10 + lastDigit;
}

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число -> {number}");

int newDigit = NewDigit(number);
Console.WriteLine($"{number} -> {newDigit}");

// int firstDigit = number / 100;
// int lastDigit = number % 10;

// Console.WriteLine($"{number} -> {firstDigit}{lastDigit}");