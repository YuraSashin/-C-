// Напишите програамму, которая на вход принимает
//  два числа и проверяет, является ли одно число квадратом другого

Console.Write("Введите первое  целое число: ");// Запросил целое число
int a = Convert.ToInt32(Console.ReadLine());// Ковертировал число из текста в int
Console.Write("Введите второе целое число: ");// Запросил второе целое число
int b = Convert.ToInt32(Console.ReadLine());// Конвертировал второе целое число из текста в int
bool Square( int arg1, int arg2)//Создал функцию
{
return arg1 == arg2*arg2 || arg2 == arg1* arg1 ;//Проверяю, является ли одно число квадратом другого
}
if(Square(a,b)) Console.WriteLine($" {a}, {b} => да");// Вывожу ответ, если функция выполняется
else Console.WriteLine($"{a}, {b} => НЕТ");//Вывожу ответ, если функция Не выполняется
