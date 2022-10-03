//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)//Метод создания случайного массива
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
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

int Honest(int[] array)
{
int count = default;
for (int i = 0; i < array.Length; i++)
{
    if(array[i]%2 == 0) count++;
}
return count;
}
int[] arr = CreateArrayRndInt(10, 100, 1000);
PrintArray(arr);
int honest = Honest(arr);
Console.WriteLine($"-> {honest}");