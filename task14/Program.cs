//  Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите первое  целое число: ");//Запросил целое число
int a = Convert.ToInt32(Console.ReadLine());// Конвертировал целое число из текста в int
bool Мultiple(int arg)//Создал функцию
{
    return arg%7 == 0 && arg%23 == 0; // Проверяю кратность чила одновремено на 7 и 23
}
if(Мultiple(a)) Console.WriteLine($"Число {a} кратно одновременно 7 и 23");//Вывожу ответ, если функия выполняется
else Console.WriteLine($"Число {a} НЕ кратно одновременно 7 и 23");//Вывожу ответ, если функция не выполняется