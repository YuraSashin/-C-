//  Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите первое  целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
bool Мultiple(int arg)
{
    return arg%7 == 0 && arg%23 == 0;
}
if(Мultiple(a)) Console.WriteLine($"Число {a} кратно одновременно 7 и 23");
else Console.WriteLine($"Число {a} НЕ кратно одновременно 7 и 23");