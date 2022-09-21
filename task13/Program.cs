// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите целое число: "); //запрсил число
int a = Convert.ToInt32(Console.ReadLine());// Конвертировал число из текста в int
if (a < 99)
{
    Console.WriteLine($"{a} -> Третьей цифры нет");
}
else
{
  int RemoveSekondDigit ( int arg) 
  {
int firstDigit = arg%1000;
int lengthDigit = firstDigit/100;
return lengthDigit;
  } 
  int transformation = RemoveSekondDigit(a);
  Console.WriteLine($"Третье цифра числа{a} -> {transformation} ");
}