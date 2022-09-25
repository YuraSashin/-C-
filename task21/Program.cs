// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите х1 ");//Запросил х1
int x1 = Convert.ToInt32(Console.ReadLine());//Конвертировал х1 в int
Console.Write("Введите y1 ");//Запросил у1
int y1 = Convert.ToInt32(Console.ReadLine());//Конвертировал у1 в int
Console.Write("Введите z1 ");//Запросил z1
int z1 = Convert.ToInt32(Console.ReadLine());//Конвертировал z1 в int
Console.Write("Введите x2 ");//запросил х2
int x2 = Convert.ToInt32(Console.ReadLine());//Конвертировал х2 в int
Console.Write("Введите y2 ");//запросил у2
int y2 = Convert.ToInt32(Console.ReadLine());//Конвертировал у2 в int
Console.Write("Введите z2 ");//Запросил z2
int z2 = Convert.ToInt32(Console.ReadLine());//Конвертировал z2 в int

double Distan( int argX1 , int argY1, int argZ1, int argX2, int argY2, int argZ2 )//Объявил новую функцию
{
    double resault = Math.Sqrt(Math.Pow((argX2 - argX1 ),2)+Math.Pow((argY2 -argY1),2)+Math.Pow((argZ2 -argZ1),2));//Ввёл формулу нахождения расстояния двух точек в 3D
    return resault ;//Вернул получившийся результат
}
double distance = Distan(x1,y1,z1,x2,y2,z2);//Обращаюсь к функции подставив значения пользователя
Console.WriteLine(Math.Round(distance,2, MidpointRounding.ToZero));//Вывожу ответ, округленный до 2 знаков