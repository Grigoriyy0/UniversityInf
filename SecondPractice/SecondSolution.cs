namespace SecondPractice;

class SecondSolution()
{
    public static double Solve(double x1, int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += double.Pow(x1, i) / CalculateFactorial(i);
        }

        return sum;
    }

    public static int CalculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        return n * CalculateFactorial(n - 1);
    }
}