//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
void PrintMatrix(int[,] matrix)//Метод вывода  двумерного массива
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
int[] AuxiliarySortingArray(int[] array)//Метод сортировки массива
{
    Array.Sort(array);
    int size = array.Length;
    int index1 = default;
    int index2 = size - 1;
    while (index1 < index2)
    {
        int obj = array[index1];
        array[index1] = array[index2];
        array[index2] = obj;
        index1++;
        index2--;
    }
    return array;
}

void SortingMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)// matrix.GetLength(0) это колличество строк(rows), индекс показывает измерение массива
    {
        int[] arrayRows = new int[matrix.GetLength(0)];//Преобразовал строку в отдельный массив
        for (int j = 0; j < matrix.GetLength(1); j++)//matrix.GetLength(1) это колличество столбцов(columns)
        {
            arrayRows[j] = matrix[i, j];
        }
        AuxiliarySortingArray(arrayRows);//Обратился к методу сортировки массива
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            matrix[i, k] = arrayRows[k];
        }
    }
}
int[,] array2D = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2D);
SortingMatrix(array2D);
Console.WriteLine();
PrintMatrix(array2D);
