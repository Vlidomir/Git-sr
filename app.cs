// version 2.0.0 
using System;

class Program
{
    // Метод, возвращающий разность двух чисел
    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static void Main()
    {
        int a = 30;
        int b = 12;
        int result = Subtract(a, b);
        Console.WriteLine($"Разность: {result}");
    }
}
