﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)//Метод создания случайного двумерного  массива, вещественных чисел
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)// matrix.GetLength(0) это колличество строк(rows), индекс показывает измерение массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++)//matrix.GetLength(1) это колличество столбцов(columns)
        {
            matrix[i, j] = Math.Round (rnd.NextDouble() * (max-min)+min, 2, MidpointRounding.ToZero);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)//Метод вывода массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 8}; ");
            else Console.Write($"{matrix[i, j], 8}");
        }
        Console.WriteLine("]");
    }
}

double[,] array2D = CreateMatrixRndInt(4,5,-10,10);
PrintMatrix(array2D);