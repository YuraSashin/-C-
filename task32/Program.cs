// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
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
void InversionNum(int[] array)//Метод инверсии массива
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i]* (-1);
}

}
int[] arr = CreateArrayRndInt(12, -9, 9);//Создал случайный массив длинна 12, диапазон -9; 9
PrintArray(arr);//Вывел случайный массивint[] arr = CreateArrayRndInt(12, -9, 9);
InversionNum(arr);//Сделал инверсию массива
PrintArray(arr);//Вывел изменённый массив