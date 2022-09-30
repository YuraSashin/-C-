// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите  число: ");
int a = Convert.ToInt32( Console.ReadLine());

int Sum(int num)
{
    int res = default;
    for (int i = 0; i < num; i++)
    {
    res = res + num%10; 
    num = num/10;
    }
    return res;
}
int sum = Sum(Math.Abs(a));
Console.WriteLine($"{a} -> {sum}");