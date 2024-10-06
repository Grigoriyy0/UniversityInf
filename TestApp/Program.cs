using System;
namespace TestApp;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите числа m и n");
        double m = Double.Parse(Console.ReadLine());
        double n = Double.Parse(Console.ReadLine());
        
        Solve(m, n);
    }

    public static void Solve(double m, double n)
    {
        double z = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
        Console.WriteLine(z);
    }
}
