// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3
  Console.Write("Сколько чисел вы хотите ввести? ");
int number = Convert.ToInt32(Console.ReadLine());
int[] NumberRequest(int num)//Создал метод который позволит запросить множество чисел от пользователя и сохранить все числа пользователя в массиве
{
int i=default;
int[] arr = new int[number];//Создал массив, который будет хранить числа пользователя
while (i<number)
{
    Console.Write("введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
arr[i] = numbers;//Сохраняю число в конкретной позиции массива
i++;
}
return arr;
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
void CheckPositiv(int[] array)//Создал метод проверки положительных чисел
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i]>0) count++ ;
    }
    Console.WriteLine($"Количество введённый вами положительных чисел -> {count} ");
}
int[] numberRequest = NumberRequest(number);
PrintArray(numberRequest);
CheckPositiv(numberRequest);
