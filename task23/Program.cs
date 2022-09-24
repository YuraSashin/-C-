﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите число: ");// запросил число пользователя
int num = Convert.ToInt32(Console.ReadLine()); //конвертировал число пользователя в int
void CubicTable(int a)//Создал функцию
{
    int count = 1;//Создал счётчик
    while (count <= a)//Создал цикл
    {
        Console.WriteLine($"{count} {count*count*count}");//Вовращаю текущее значение и его куб
        count++;//увеличиваю счетчик на 1
    }
}
if (num>0) CubicTable(num);//Ввожу условие и обращаюсь к функции
else Console.WriteLine(" Введено некоректное значение");// Вывожу ответ, если число меньше 0