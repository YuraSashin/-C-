﻿//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели (1-7): "); //запросил число
int a = Convert.ToInt32(Console.ReadLine());// Конвертировал число из текста в int
if (a>8 || a<0)//создал границы диапазона цифр
{
    Console.WriteLine("Введите пожалуйста число от 1 до 7");//Прошу пользователя ввести цифру, согласно условия
}
if (a<6)//Создал диапазон будних дней
{
    Console.WriteLine($" {a} -> нет "); // Вывожу ответ, если день является будним
}
if (a == 6 || a == 7)//Создал диапазон выходных дней
{
    Console.WriteLine($" {a} -> Да ");//Вывожу ответ, если день является выходным
}