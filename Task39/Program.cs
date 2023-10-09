// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

void PrintReversArray(int[] arr)
{
    int res = 0;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        res = arr[arr.Length - 1 - i];
        if (i < arr.Length - 1)
            Console.Write($"{res}, ");
        else Console.Write($"{res}");
    }
    Console.WriteLine("]");
}

int[] array = CreateArrayRndInt(7, 1, 10);
PrintArray(array);
PrintReversArray(array);
// Array.Reverse(array);
// PrintArray(array);
