// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void Znak(int[] arr)
{
    int num = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        num = arr[i];
        num *= -1;
        if (i < arr.Length - 1) Console.Write($"{num}, ");
        else Console.Write($"{num}");
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int[] array = CreateArrayRndInt(8, -10, 10);
Console.Write("[");
PrintArray(array);
Console.Write("]");

Console.Write($" -> ");

Console.Write("[");
Znak((array));
Console.WriteLine("]");
