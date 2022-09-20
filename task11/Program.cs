//  Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int RemoveSekondDigit(int number) // объявляем метод и количество переменных
{
int firstDigit = number % 10; // выделяем остаток
int sekondDigit = number / 100; // удаляем остаток, крайние 2 цифры
int lengthDigit = sekondDigit * 10 + firstDigit; // получаем число из 2 цифр

return lengthDigit; // возвращаем результат метода
}

int Randomnumber = new Random().Next(100, 1000); // получаем трехзначное псевдослучайное число
int twonumber = RemoveSekondDigit(Randomnumber); // запускаем метод, результат записываем в переменную

Console.WriteLine(Randomnumber); // показываем рандомное число для проверки
Console.WriteLine($"После удаления второй цифры, осталось число: {twonumber}"); // записываем результат