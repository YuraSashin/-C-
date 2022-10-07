// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)//Метод создания случайного двумерного массива массива
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }
}
int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);