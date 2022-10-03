// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int QuantityElemRande (int[]array, int min, int max)//Создал метод по нахождению конкретный чисел в диапазоне
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>= min && array[i]<max) count++;
    }
    return count;
}
int[] arr = CreateArrayRndInt(123, 0, 1000);//Создал случайный массив длинна 123, диапазон 0; 1000
PrintArray(arr);//Вывел случайный массив на экран
int quantityElemRande = QuantityElemRande(arr,10,99);//Обратился к методу нахождения конкретных значений в диапазон, подставил случайный массив и диапазон
Console.WriteLine($"-> {quantityElemRande}");