// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет
Console.Write("Введите значение строки (0 - значение первой строки): ");
int row = Convert.ToInt32(Console.ReadLine() );
Console.Write("Введите значение столбца(0 - значение первого столбца): ");
int column = Convert.ToInt32(Console.ReadLine() );

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

int ElementValue(int[,] matrix, int numRows, int numCoumns)
{
    int element = matrix[numRows, numCoumns];

    return element;
}
int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
if (row > array2D.GetLength(0) - 1 || column > array2D.GetLength(1) - 1)
{
    Console.WriteLine("Такого элемента в массиве нет");
}
else
{
    PrintMatrix(array2D);
    int elementValue = ElementValue(array2D, row, column);
    Console.WriteLine($"Значение заданного элемента -> {elementValue}");
}