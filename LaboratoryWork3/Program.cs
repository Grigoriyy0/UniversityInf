namespace LaboratoryWork3;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("|-------------------|\n" +
                              "|     Вариант 6     |\n" +                  
                              "|-------------------|\n" +
                              "| Выберите задание: |\n" +                
                              "| 1. Первое задание |\n" +
                              "| 2. Второе задание |\n" +
                              "| 3. Третье задание |\n" +
                              "| 4. Выход          |\n" +
                              "|-------------------|\n");
            var input = Console.ReadLine();
            if (input ==  "1")
            {
                
                Console.WriteLine("Введите количество элементов массива");
                int n = int.Parse(Console.ReadLine()!);
        
                double[] arr = new double[n];

                Console.WriteLine("Вводите элементы массива");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = double.Parse(Console.ReadLine()!);
                }

                FirstTask.GetMin(arr);
                FirstTask.GetSum(arr);
                foreach (var item in FirstTask.Sort(ref arr))
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
                Console.WriteLine("Желаете вернуться? (y / n)");
                var inp = Console.ReadLine();
                if (inp == "y")
                {
                    continue;
                }
                else if(inp == "n")
                {
                    break;
                }
            }

            if (input == "2")
            {
                Console.WriteLine("Введите количество строк матрицы:");
                int rowsNumber = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Введите количество столбцов матрицы: ");
                int columnsNumber = int.Parse(Console.ReadLine()!);
                int[,] arr = new int[rowsNumber, columnsNumber];
                Console.WriteLine("Вводите элементы матрицы");
                for (int s = 0; s < rowsNumber; s++)
                {
                    for (int d = 0; d < columnsNumber; d++)
                    {
                        arr[s, d] = int.Parse(Console.ReadLine()!);
                    }
                }
                SecondTask.GetSumOfRowsWithNegative(arr, rowsNumber, columnsNumber);
                Console.WriteLine();
                Console.WriteLine("Седловые течоки матрицы:");
                SecondTask.FindSedlPoints(arr, rowsNumber, columnsNumber);
                Console.WriteLine();
                Console.WriteLine("Желаете продолжить? (y / n)");
                var inp = Console.ReadLine();
                if (inp == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            if (input == "3")
            {
                Console.WriteLine("Введите текст: ");
                var text = Console.ReadLine();
                Dictionary<char, int> dict = new Dictionary<char, int>();
                for (int i = 0; i < text.Length; i++)
                {
                    if (dict.ContainsKey(text[i]))
                    {
                        dict[text[i]]++;
                    }
                    else
                    {
                        dict.Add(text[i], 1);
                    }
                }

                string Vowels = "АУОИЭЫЯЮЕЁ";
                string Consonants = "БВГДЖЗЙКЛМНПРСТФХЦЧЩШ";
                
                var firstMaxVow = dict.OrderByDescending(x => x.Value).First();
                
                
                foreach (var pair in dict)
                {
                    Console.WriteLine($"{pair.Key} = {pair.Value}");
                }
            }

            if (input == "4")
            {
                break;
            }
        }


    }
}

class ThirdTask
{
    
}