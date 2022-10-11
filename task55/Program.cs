// Задайте двухмерный массив, напишите программу,
// которая заменяет строки на столбцы. В случае если это невозможно,
// программа должна вывести это пользователю

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
int[,] ReplaseRowsColums(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1),matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0) ; i++)
    {
        for (int j = 0; j < matrix.GetLength(1) ; j++)
        {
            newMatrix[i,j] = matrix[j,i];
        }
    } 
    return newMatrix;
}
 int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
 if(array2D.GetLength(0)== array2D.GetLength(1))
 {
    PrintMatrix(array2D);
    int[,] replaseRowsColums = ReplaseRowsColums(array2D);
    Console.WriteLine();
    PrintMatrix(replaseRowsColums);
 }
 else Console.WriteLine("Невозможно поменять строки на столбцы");


