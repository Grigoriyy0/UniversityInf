namespace LaboratoryWork4;

class FirstTask
{
    public static void ShowFiles(string path)
    {
        string[] files = Directory.GetFiles(path);

        foreach (string file in files)
        {
            string fileName = Path.GetFileName(file);
            Console.WriteLine(fileName);
        }

    }

    public static void MovingAverage(string file)
    {
        double average = 0;
        int count = 0;
        string[] data = File.ReadAllLines($"C:\\LaboratoryWork4\\Storage\\{file}");

        foreach (var str in data)
        {
            count++;
            average += double.Parse(str.Split(' ')[1]);
            Console.WriteLine(average);
        }
        
        Console.WriteLine(average / count);
    }
}