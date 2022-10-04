// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 Console.Write("Задайте точку b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте точку k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("Задайте точку b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
 Console.Write("Задайте точку k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double[] Intersection(double numB1, double numK1, double numB2, double numK2)
{
    double y = default;
    double x = default;
    double[] array = new double[2];
    x = (numB2-numB1)/(numK1-numK2);
    y = numK1*x+numB1;
    array[0] = x;
    array[1] = y;
    return array;
    }

void PrintArray(double[] array)//Метод вывода массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}
if (b1/b2 == k1/k2) Console.WriteLine("Прямые паралельны");
else
{
double[] intersection = Intersection(b1,k1,b2,k2);
PrintArray(intersection);
}
