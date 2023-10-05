// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Input(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Multiply(int numA, int numB)
{
    int res = 1;
    for (int i = 0; i < numB; i++)
    {
        res = res * numA;
    }
    return res;
}

int numberA = Input("Введите целое число ");
int numberB = Input("Введите натуральное целое число ");

Console.WriteLine($"{numberA}, {numberB} -> {Multiply(numberA, numberB)}");
