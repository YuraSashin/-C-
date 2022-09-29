// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите первое число: ");
int a = Convert.ToInt32( Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32( Console.ReadLine());
int Degree(int num1, int num2)
{
    int counter = 1;
    int work = 1;
    while (counter<=num2)
    {
       work = work*num1;
       counter++;
    }
    return work;
}
int degree = Degree(a,b);
Console.WriteLine($"{a},{b} -> {degree}");