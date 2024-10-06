namespace Practice1;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите общее количество журавликов");
        int amount = int.Parse(Console.ReadLine());
        
        int Kate = amount * 2 / 3;
        int Pyotr = (amount - Kate) / 2;
        int Sergey = Pyotr;

        Console.WriteLine($"Петя сделал: {Pyotr} журавликов, Катя сделала: {Kate} журавликов, Сергей сделал: {Sergey} журавликов");
        
    }
    
}