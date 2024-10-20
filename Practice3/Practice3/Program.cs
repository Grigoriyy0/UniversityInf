namespace Practice3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var c1 = new Cicrcle(10);
        c1.CalculateCircumference();
    }
}

public class Cicrcle
{
    public double CircleRadius { get; set; }

    public Cicrcle(double circleRadius)
    {
        CircleRadius = circleRadius;
    }

    public void CalculateCircumference()
    {
        Console.WriteLine(2*Math.PI*CircleRadius);
    }
}