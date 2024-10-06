using System.Text;
using System.Text.RegularExpressions;

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
                string text = Console.ReadLine()!;
                var vowelCounts = new Dictionary<char, int>();
                var consonantCounts = new Dictionary<char, int>();
                foreach (char c in text.ToLower())
                {
                    if ("аоуэиыеёюя".Contains(c))
                    {
                        vowelCounts[c] = vowelCounts.ContainsKey(c) ? vowelCounts[c] + 1 : 1;
                    }
                    else if (char.IsLetter(c))
                    {
                        consonantCounts[c] = consonantCounts.ContainsKey(c) ? consonantCounts[c] + 1 : 1;
                    }
                }

                var mostFrequentVowels = vowelCounts.OrderByDescending(x => x.Value).Take(2).Select(x => x.Key).ToArray();
                var mostFrequentConsonants = consonantCounts.OrderByDescending(x => x.Value).Take(2).Select(x => x.Key).ToArray();

                var result = new StringBuilder(text);
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i].ToString().ToLower() == mostFrequentVowels[0].ToString())
                    {
                        result[i] = char.IsUpper(result[i]) ? char.ToUpper(mostFrequentConsonants[0]) : char.ToLower(mostFrequentConsonants[0]);
                    }
                    else if (result[i].ToString().ToLower() == mostFrequentVowels[1].ToString())
                    {
                        result[i] = char.IsUpper(result[i]) ? char.ToUpper(mostFrequentConsonants[1]) : char.ToLower(mostFrequentConsonants[1]);
                    }
                    else if (result[i].ToString().ToLower() == mostFrequentConsonants[0].ToString())
                    {
                        result[i] = char.IsUpper(result[i]) ? char.ToUpper(mostFrequentVowels[0]) : char.ToLower(mostFrequentVowels[0]);
                    }
                    else if (result[i].ToString().ToLower() == mostFrequentConsonants[1].ToString())
                    {
                        result[i] = char.IsUpper(result[i]) ? char.ToUpper(mostFrequentVowels[1]) : char.ToLower(mostFrequentVowels[1]);
                    }
                }

                Console.WriteLine(result);
                Console.WriteLine("Желаете продолжить? (y / n)");
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

            if (input == "4")
            {
                break;
            }
        }


    }
}
