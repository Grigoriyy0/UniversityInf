namespace Practice2;

class Program
{
    public static void Main(string[] args)
    {
       int numOfTickets = int.Parse(Console.ReadLine()!);
       int[] tickets = new int[numOfTickets];
       for (int i = 0; i < numOfTickets; i++)
       {
           tickets[i] = int.Parse(Console.ReadLine()!);
       }

       foreach (var ticket in tickets)
       {
           if (IsOneStepFromHappiness(ticket))
           {
               Console.WriteLine("Yes");
           }
           else
           {
               Console.WriteLine("No");
           }
       }
    }
    
    static bool IsOneStepFromHappiness(int ticketNumber)
    {
        int sumFirstHalf = SumOfDigits(ticketNumber / 1000);
        int sumSecondHalf = SumOfDigits(ticketNumber % 1000);
        
        if (Math.Abs(sumFirstHalf - sumSecondHalf) == 1)
        {
            return IsLucky(ticketNumber - 1) || IsLucky(ticketNumber + 1);
        }

        return false;
    }
    
    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
    
    static bool IsLucky(int ticketNumber)
    {
        int sumFirstHalf = SumOfDigits(ticketNumber / 1000);
        int sumSecondHalf = SumOfDigits(ticketNumber % 1000);
        
        return sumFirstHalf == sumSecondHalf;
    }
    
}
