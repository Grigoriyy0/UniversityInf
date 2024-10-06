namespace LaboratoryWork4;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("------------------------\n" +
                              "|       Вариант 6      |\n" +
                              "|----------------------|\n" +
                              "| Выберите пункт меню: |\n" +
                              "| 1. Первое задание    |\n" +
                              "| 2. Второе Задание    |\n" +
                              "| 3. Выход             |\n" +
                              "|----------------------|\n");
            
            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Анализ временных рядов");        
                Console.WriteLine("Выберите файл из списка для выполнения скользящего среднего: ");
                string path = @"C:\LaboratoryWork4\Storage";
                FirstTask.ShowFiles(path);
                var file = Console.ReadLine();
                Console.WriteLine("Среднее значение за весь период времени: ");
                FirstTask.MovingAverage(file);
                Console.WriteLine("Желаете продолжить? (y / n)");
                var inp = Console.ReadLine();
                if (inp == "y")
                {
                    continue;
                }
                else if (inp == "n")
                {
                    break;
                }
                
            }
            else if (input == "2")
            {
                Func<double, double> func = (x) => (Math.Pow(x,3) - 9 * Math.Pow(x,4) - 1);
                Console.WriteLine("Интегрирование функции x^3 - 9 * x^4 - 1 методом выходящих прямоугольников");
                Console.WriteLine("Желаете ли вы изменить пределы интегрирования (По стандарту от 0 до 5)? (y / n)");
                var inp = Console.ReadLine();
                if (inp == "y")
                {
                    Console.WriteLine("Введите желаемые пределы интегрирования: ");
                    var lowerLimit = double.Parse(Console.ReadLine());
                    var upperLimit = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите количество шагов: ");
                    var steps = int.Parse(Console.ReadLine());
                    SecondTask.Solve(func, lowerLimit, upperLimit, steps);
                    
                    Console.WriteLine("Желаете продолжить? (y/n)");
                    var choice  = Console.ReadLine();
                    if (choice == "y")
                    {
                        continue;
                    }
                    else if (choice == "n")
                    {
                        break;
                    }
                }
                else if (inp == "n")
                {
                    Console.WriteLine("Введите количество шагов: ");
                    var steps = double.Parse(Console.ReadLine());
                    SecondTask.Solve(func, 0, 5, steps);
                    
                    Console.WriteLine("Желаете продолжить? (y/n)");
                    var choice  = Console.ReadLine();
                    if (choice == "y")
                    {
                        continue;
                    }
                    else if (choice == "n")
                    {
                        break;
                    }
                }
            }
            else if (input == "3")
            {
                break;
            }
        }

    }
}