// напишите программу,которая принимает на вход число(N) и выдаёт таблицу квадратов чисел от 1 до N

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
void SquareTable(int a)
{
    int count = 1;
    while (count <= a)
    {
        Console.WriteLine($"{count} {count*count}");
        count++;
    }
}
if (num>0) SquareTable(num);
else Console.WriteLine(" Введено некоректное значение");
