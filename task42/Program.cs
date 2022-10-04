//Напишите программу, которая буде преобразовывать десятичное число в двоичное

Console.Write("Введите первое  число: "); //запросил число
int a = Convert.ToInt32(Console.ReadLine());// Конвертировал число из текста в int

int TranslationBinarySystem(int num)
{
   int binary = 0;
   int count =1;
    
while (num>=1)
{
binary= binary+num%2*count;
count=count*10;
num=num/2;
}
return binary;
}

int translationBinarySystem = TranslationBinarySystem(a);
Console.WriteLine($"{a} = {translationBinarySystem}");