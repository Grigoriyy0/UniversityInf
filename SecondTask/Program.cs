using System.Security.Cryptography;

namespace SecondTask;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты вершин");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        
        FindPerimetrAndArea(x1,y1,x2,y2,x3,y3);
    }

    public static void FindPerimetrAndArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double fisrtSide = Math.Sqrt((x2-x1)*(x2-x1) + (y2 - y1)*(y2 - y1));
        double secondSide = Math.Sqrt((x3-x2)*(x3-x2) + (y3-y2)*(y3-y2));
        double thirdSide = Math.Sqrt((x1-x3)*(x1-x3) + (y1-y3)*(y1-y3));
        
        Console.WriteLine($"Периметр : {fisrtSide + secondSide + thirdSide}");
        
        double HalfPerimeter = (fisrtSide + secondSide + thirdSide) / 2.0;
        double Area = Math.Sqrt(HalfPerimeter * (HalfPerimeter - fisrtSide) * (HalfPerimeter - secondSide) * (HalfPerimeter - thirdSide));
        
        Console.WriteLine($"Площадь: {Area:E2}");
    }
}

