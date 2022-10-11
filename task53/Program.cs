//Задайте двухмерный массив. Наппишите программу, которая поменяет местами первую и последнюю строку Массива

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
void NewMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int obj = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0)-1,j] = obj;
    } 
}
int [,] araay2D = CreateMatrixRndInt(4,4,0,10);
PrintMatrix(araay2D);
Console.WriteLine();
NewMatrix(araay2D);
PrintMatrix(araay2D);