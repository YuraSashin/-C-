// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] CreateArrayRndInt(int size, int min, int max)//Метод создания случайного массива
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
     array[i] = Math.Round (rnd.NextDouble() * (max-min)+min, 1, MidpointRounding.ToZero);// Создал случайный массив в диапазоне от мин до макс, округлённый до 1 знака
    }
    return array;
}
void PrintArray(double[] array)//Метод вывода массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}
double Difference(double[] array)//Создал метод по нахлждению max и min  и их разницы
{
    double imin = array[0];//создал минимум и присвоил значение первого элемента массива (если присвоить defolt, то минимум останется равен нулю)
    double imax = default;// создал максимум, присвоил значение defolt
    for (int i = 0; i < array.Length; i++)// Создал цикл, в котором один раз прогоню все элементы и найду нужные мне значения
    {
        if(array[i]>imax) imax = array[i];//нахожу максимум
        if(array[i]<imin) imin = array[i];//нахожу минимум
    }
double diff = imax - imin;//Нахожу разность между ними
return diff;// возвращаю разность
}

double[] arr = CreateArrayRndInt(10, 0, 100);//Создаю случайный массив: длинна 10, дипазон 0 - 100
PrintArray(arr);//Вывожу массив на экран
double difference = Difference(arr);//Обращаюсь к функции по нахожднеию разности, подставив случайный массив
Console.WriteLine($"-> {difference}");//Вывожу результат