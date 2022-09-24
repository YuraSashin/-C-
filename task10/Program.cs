﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите целое, трехзначное число: "); //запрсил число
int a = Convert.ToInt32(Console.ReadLine());// Конвертировал число из текста в int
if (a>1000 || a<99 ) // Добавил диапазон чисел пользователю, согласно условию
{
    Console.WriteLine($"Ваше число {a} не соответствует условию, введите, пожалуйста, трехзначное число"); // Вывод результата, в случае не сооответствия условию
}
else // Дальнейшие действия, согласно диапозону
{
int RemoveSekondDigit( int arg) //Создал функцию
{
    int firstDigit = arg%100; // Выделил остаток деления на 100
    int lengthDigit = firstDigit/10 ;// Получил результат путем деления результата предедущего пункта на 10
    return lengthDigit; // Возвращения конечного результата
}

int transformation = RemoveSekondDigit(a); // Обращаюсь к функции через новую переменную, подставляя число пользователя
Console.WriteLine($" Вторая цифра числа {a} => {transformation}"); // Вывожу результат пользователю
}