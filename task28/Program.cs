// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
Console.Write("Введите число: ");
int number = Convert.ToInt32( Console.ReadLine());
int Factorial( int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact = fact * i;
    }
    return fact;
}
if(number>0)
{
    int sumresult = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {sumresult} ");
}
else
{
    Console.WriteLine("Число не соответствует условию");
}