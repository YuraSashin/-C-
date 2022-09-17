// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое  целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье  целое число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    if (a>c)
    {
        Console.WriteLine($" {a} = максимум ");
    }
}
if (b>a)
{
    if (b>c)
    {
        Console.WriteLine($" {b} = максимум ");
    }
}
if (c>a)
{
    if (c>b)
    {
        Console.WriteLine($" {c} = максимум ");
    }
}






