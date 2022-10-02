// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
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
bool CheckNum(int[]array, int arg)//Создал метод по нахождению конкретного числа в случайном массиве
{
    bool checkNum = false;//Присвоил значение переменной - "ложь"
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == arg)
        {
            checkNum = true;//Присвоил переменной значение "правда", в случае нахождения нужного числа
            break;
        }
    }
    return checkNum;
}
int[] arr = CreateArrayRndInt(12, -9, 9);//Создал случайный массив длинна 12, диапазон -9; 9
PrintArray(arr);//Вывел случайный массивint[] arr = CreateArrayRndInt(12, -9, 9);
bool checkNumber = CheckNum(arr,number);// Обратился к методу по нахождению числа в случайном массиве
if(checkNumber) Console.WriteLine("да");// Вывод результата, если число найдено
else Console.WriteLine("нет");//Вывод результата, если число НЕ найдено