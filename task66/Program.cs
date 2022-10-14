// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNum(int numberM, int numberN)
{
    if (numberM == numberN + 1) return 0;
    int res = numberM;
    res += SumNum(numberM + 1, numberN);
    return res;
}
if (numberN > numberM)
{
    int sumNum = SumNum(numberM, numberN);
    Console.WriteLine(sumNum);
}
else
{
    int sumNum = SumNum(numberN, numberM);
    Console.WriteLine(sumNum);
}