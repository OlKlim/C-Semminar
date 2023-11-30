// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа n и m.
// n = 2, m = 3 -> A(n,m) = 9
// n = 3, m = 2 -> A(n,m) = 29

Console.Write("Введите натуральное положительное число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное положительное число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());

int ack = Ack(numberN, numberM);
Console.WriteLine(ack);

int Ack(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return Ack(n - 1, 1);
    return Ack(n - 1, Ack(n, m - 1));
}