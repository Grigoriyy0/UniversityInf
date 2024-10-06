namespace LaboratoryWork4;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Выберите файл из списка: ");
        string path = @"C:\LaboratoryWork4\Storage";
        string[] files = Directory.GetFiles(path);

        foreach (string file in files)
        {
            string fileName = Path.GetFileName(file);
            Console.WriteLine(fileName);
        }
        var chosenFile = Console.ReadLine();
        
        string[] data = File.ReadAllLines($"C:\\LaboratoryWork4\\Storage\\{chosenFile}");
        -
    }
}