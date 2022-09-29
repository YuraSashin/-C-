// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]Задача 30: Напишите программу, которая
 
 int[] array = new int[8];
 int[] resarray = GetArray(array);
 PrintArray(array);
 int[] GetArray(int[] arr)
 {
    int lenght = arr.Length;
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
    return arr;
 }
 void PrintArray(int[] array)
 {
    int count = array.Length;
for (int i = 0; i < count; i++)
{
    Console.Write($"{array [i] } ");
}
Console.WriteLine();
 }

