
// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random() .Next(10,100);
// Console.WriteLine($"случайное число из отрезка 10-99 => {number}" );
// int firstDigit = number/10;
// int secondDigit = number%10;
// if (firstDigit > secondDigit)
// {
//     Console.WriteLine($"Наибльшая цифра числа {number}, = {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"Наибльшая цифра числа {number}, = {secondDigit}");
// }
// if (firstDigit == secondDigit)
// {
//     Console.WriteLine("Числа равны");
// }
// или можно через функцию

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
    if(firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
int number = new Random().Next(10, 100);
int maxDigit = MaxDigit(number);
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
Console.WriteLine($"Наибльшая цифра числа {number}, = {result}");