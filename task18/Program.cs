﻿//  Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти ");
int number = Convert.ToInt32(Console.ReadLine());
string Quarter( int num)
{
    if (num == 1) return "x>0 , y>0" ;
    if(num == 2) return "x<0, y>0";
    if(num  == 3) return "x<0, y<0";
    if(num == 4) return "x>0, y<0" ;
    return "Введите число от 1 до 4";

}

string result = Quarter(number);
Console.WriteLine(result);
