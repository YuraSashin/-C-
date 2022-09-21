// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
 
Console.Write("Введите первое  целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
bool Division(int arg1, int arg2)
{
    return arg1 % arg2 == 0;
}
if (Division(a,b)) Console.WriteLine($"Число {a} кратно числу {b}");
else Console.WriteLine($"Число {a} не картно числу {b}, остаток {a%b}");
    
