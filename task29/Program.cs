// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

 int[] array = new int[8];
 int[] resarray = GetArray(array);
 PrintArray(array);
 int[] GetArray(int[] arr)
 {
    int lenght = arr.Length;
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = new Random().Next(0 ,100);
    }
    return arr;
 }
 void PrintArray(int[] array)
 {
    int count = array.Length;
for (int i = 0; i < count; i++)
{
    Console.Write($"{array [i] }, ");
}
Console.WriteLine();
 }