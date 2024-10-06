namespace LaboratoryWork4;

class SecondTask
{
    public static void Solve(Func<double, double> func, double upperLimit, double lowerLimit, double steps)
    {
        double result = 0;
        double rectangleWidth = (upperLimit - lowerLimit) / steps;

        for (double i = 1; i <= steps; i++)
        {
            double x = lowerLimit + i * rectangleWidth;
            result += func(x);
        }
        Console.WriteLine($"Приблизительное значение интеграла: {result*rectangleWidth:F6}");
    } 
}