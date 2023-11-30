// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 1 || numberN < 1)
{
    Console.WriteLine("Неккоректный ввод!");
    return;
}

Console.WriteLine(Sum(numberM, numberN));

int Sum(int numM, int numN) // 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15
{
        if (numM == numN) return numM;
        return numM + Sum(numM + 1, numN); // 1 2 3 4 5 6 7 8 9 10 11 12 13 14
        // retuen 15 + 14 + 13...+1 = 120
}