//  Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int number = Convert.ToInt32( Console.ReadLine());
int Sumnumbers( int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}
int sumresult = Sumnumbers(number);
Console.WriteLine($"Сумма числел от 1 до {number} = {sumresult} ");