//  Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int pow = Convert.ToInt32(Console.ReadLine());

int GetPowNum(int num, int numPow)
{
    if (numPow == 0) return 1;
    int res = num;
    res *= GetPowNum(num, numPow - 1);
    return res;
}

int getPowNum = GetPowNum(number, pow);
Console.WriteLine($"Число {number} в степени {pow} = {getPowNum}");