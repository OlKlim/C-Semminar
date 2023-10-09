// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] FiboArray(int num)
{
    int[] fibo = new int[num];
    fibo[1] = 1;
    for (int i = 2; i < fibo.Length; i++)
    {
        fibo[i] = fibo[i - 1] + fibo[i - 2];
    }
    return fibo;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

Console.Write("Введите число цифр фибоначчи : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 2) 
{
    Console.Write("Неверное число (менее 1)");
    return;
}

int[] res = FiboArray(number);
Console.Write($"Если N = {number} -> ");
PrintArray(res);