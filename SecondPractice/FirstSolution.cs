namespace SecondPractice;

class FirstSolution()
{
    public static void Solve(double x, double y)
    {
        if (x < 0 && y < 0 )
        {
            x = double.Abs(x);
            y = double.Abs(y);
        }
        else if (x < 0 && y > 0 || x > 0 && y < 0)
        {
            x += 0.5;
            y += 0.5;
        }
        else if (x >= 0 && y >= 0 && !(x >= 0.5 && x <= 2.0) && !(y >= 0.5 && y <= 2.0))
        {
            x /= 10;
            y/=10;
        }
        
        Console.WriteLine($"X : {x}, Y : {y}");
    }
}