namespace Practice2;

class Program
{
    public static void Main(string[] args)
    {
        string input = @"C:\Practice2\Input.txt";
        string output = @"C:\Practice2\Output.txt";

        int numberOfTest = int.Parse(File.ReadLines(input).FirstOrDefault());
        string[] data = File.ReadLines(input).Skip(1).ToArray();

        for (int i = 0; i < numberOfTest; i++)
        {
            string nextTicket = GetNextTicket(data[i]);
            string prevTicket = GetPrevTicket(data[i]);
            if (IsHappy(prevTicket) || IsHappy(nextTicket))
            {
                using (StreamWriter writer = new StreamWriter(output))
                {
                    writer.WriteLine("Yes");
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(output))
                {
                    writer.WriteLine("No");
                }
            }
        }
    }

    public static int SumInString(string input)
    {
        int sum = 0;
        foreach (char c in input)
        {
            sum += int.Parse(c.ToString());
        }
        return sum;
    }

    public static string GetPrevTicket(string ticket)
    {
        int num = int.Parse(ticket);
        return (num-1).ToString();
    }

    public static string GetNextTicket(string ticket)
    {
        int num = int.Parse(ticket);
        return (num + 1).ToString();
    }
    

    public static bool IsHappy(string ticket)
    {
        int sumFirstThree = SumInString(ticket.Substring(0,3));
        int sumLastThree = SumInString(ticket.Substring(3,3));

        if (sumFirstThree == sumLastThree)
        {
            return true;
        }
        else
        {
            return false;
        }
            
    } 
}
