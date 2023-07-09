using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение переменной x:");
        float x = float.Parse(Console.ReadLine());

        float result = (x * x - 7 * x + 10) / (x * x - 8 * x + 12);

        Console.WriteLine("Ответ: " + result);
        Console.ReadKey();
    }
}
