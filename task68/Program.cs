// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());

int FunctionAkkerman(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM > 0 && numN == 0) return FunctionAkkerman(numM - 1, 1);
    return FunctionAkkerman(numM - 1, FunctionAkkerman(numM, numN - 1));
}
if (m < 0 || n < 0) Console.WriteLine("Введите положительные числа");
else
{
    int Akkerman = FunctionAkkerman(m, n);
    Console.WriteLine($"Функция Аккермана для чисел:({m}, {n}) = {Akkerman}");
}

