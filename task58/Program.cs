// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)//Метод создания случайного двумерного массива 
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)// matrix.GetLength(0) это колличество строк(rows), индекс показывает измерение массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++)//matrix.GetLength(1) это колличество столбцов(columns)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)//Метод вывода массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i,j] += matrix1[i, k] * matrix2[k, j];
            }

        }
    }
    return resultMatrix;
}
int[,] oneArray2D = CreateMatrixRndInt(2, 2, 1, 5);
int[,] twoArray2D = CreateMatrixRndInt(2, 3, 1, 5);
if (oneArray2D.GetLength(0) == twoArray2D.GetLength(1))
{
    int[,] multiplicationMatrix = MultiplicationMatrix(oneArray2D, twoArray2D);
    PrintMatrix(oneArray2D);
    Console.WriteLine();
    PrintMatrix(twoArray2D);
    Console.WriteLine();
    PrintMatrix(multiplicationMatrix);
}
else
{
    Console.WriteLine("Нельзя перемножить данные матрицы");
}