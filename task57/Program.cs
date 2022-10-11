// Составить частотный словарь элементовдвухмерного массива.
// Частотный словарь содержит информацию о том, сколько раз
// встречается элемент входных данных

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
void PrintArray(int[] array)//Метод вывода массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}
int[] MatrixToOneRowArray(int[,] matrix)//Метод перевода двухмерного массива в одномерный
{
    int[] oneRowArray = new int[matrix.Length];
    int counter = default;
    for (int i = 0; i < matrix.GetLength(0) ; i++)
    {
        for (int j = 0; j <matrix.GetLength(1) ; j++)
        {
            oneRowArray[counter] = matrix[i,j];
            counter++;
        }
    }
    return oneRowArray;
}
void HowManyNumbersInArray(int[] array)
{
    int count = default;
    int numForCount = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(numForCount == array[i]) count++;
        else
        {
            Console.WriteLine($"{numForCount} -> {count}");
            numForCount = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{numForCount} -> {count}");
}
int [,] araay2D = CreateMatrixRndInt(4,4,0,10);
PrintMatrix(araay2D);
Console.WriteLine();
int [] matrixToOneRowArray = MatrixToOneRowArray(araay2D);
PrintArray(matrixToOneRowArray);
Array.Sort(matrixToOneRowArray);
Console.WriteLine();
PrintArray(matrixToOneRowArray);
HowManyNumbersInArray(matrixToOneRowArray);