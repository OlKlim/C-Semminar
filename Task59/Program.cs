// Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[] GetIndexesMinElem(int[,] matrix)
{
    int rowMin = 0;
    int columnMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[rowMin, columnMin])
            {
                rowMin = i;
                columnMin = j;
            }
        }
    }
    return new int[] { rowMin, columnMin };
}

int[,] DeleteRowColumnMinElem(int[,] matrix, int row, int column)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0, m = 0; i < newMatrix.GetLength(0); i++, m++)
    {
        if (i == row) m++;
        for (int j = 0, n = 0; j < newMatrix.GetLength(1); j++, n++)
        {
            if (j == column) n++;
            newMatrix[i, j] = matrix[m, n];
        }
    }
    return newMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("  |");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);

Console.WriteLine();

int[] indexesMinElem = GetIndexesMinElem(array2d);
Console.WriteLine($"row - {indexesMinElem[0]}, column - {indexesMinElem[1]}, value {array2d[indexesMinElem[0], indexesMinElem[1]]}");

Console.WriteLine();

int[,] newMatr = DeleteRowColumnMinElem(array2d, indexesMinElem[0], indexesMinElem[1]);
PrintMatrix(newMatr);