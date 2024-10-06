namespace SecondPractice;

class Program
{
    public static void Main(string[] args)
    {
         Console.WriteLine("Нажмите 1 или 2 чтобы выбрать заданте!");
         string choice = Console.ReadLine();
         if (choice == "1")
         {
             Console.WriteLine("Вы успешно выбрали первое задание!");
             Console.WriteLine();
             double x = double.Parse(Console.ReadLine());
             double y = double.Parse(Console.ReadLine());
        
             FirstSolution.Solve(x,y);
             
         }
         else
         {
             Console.WriteLine("Вы успешно выбрали второе задание");
             Console.WriteLine();
             double x1 = double.Parse(Console.ReadLine());
             int n = int.Parse(Console.ReadLine());
             Console.WriteLine(SecondSolution.Solve(x1, n));
         }
    }
}