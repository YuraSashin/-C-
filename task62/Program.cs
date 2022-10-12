// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int motion = default;
    int count = default;
    while (count < rows / 2)
    {
        for (int i = 0 + count; i < matrix.GetLength(0) - count; i++)
        {
            matrix[count, i] = motion;
            motion++;
        }
        for (int j = 1 + count; j < matrix.GetLength(1) - count; j++)
        {
            matrix[j, rows - 1 - count] = motion;
            motion++;
        }
        for (int k = matrix.GetLength(1) - 2 - count; k >= count; k = k - 1)
        {
            matrix[matrix.GetLength(1) - 1 - count, k] = motion;
            motion++;
        }
        for (int n = matrix.GetLength(1) - 2 - count; n >= count + 1; n = n - 1)
        {
            matrix[n, count] = motion;
            motion++;
        }
        count++;
    }
    if (rows % 2 == 1) matrix[rows / 2, rows / 2] = motion;
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("   ]");
    }
}
int[,] createSpiralMatrix = CreateSpiralMatrix(4, 4);
if (createSpiralMatrix.GetLength(0)== createSpiralMatrix.GetLength(1))
{
    PrintMatrix(createSpiralMatrix);
}
else Console.WriteLine("Введите квадратную матрицу");