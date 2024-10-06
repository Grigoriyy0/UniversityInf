namespace LaboratoryWork3;

public class FirstTask
{
    public static void GetMin(double[] arr)
    {
        Console.WriteLine($"Минимальный элемент: {Sort(ref arr)[0]}");
    }

    public static void GetSum(double[] arr)
    {
        double sum = 0;
        int firtPosIndex = 0;
        int lasPosIndex = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                firtPosIndex = i;
                break;
            }
        }

        for (int i = arr.Length - 1; i > 0; i--)
        {
            if (arr[i] >= 0)
            {
                lasPosIndex = i;
                break;
            }
        }
        for (int i = firtPosIndex + 1; i < lasPosIndex; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine($"Сумма элементов между первым и последним положительным: {sum}");
    }

    public static double[] Sort(ref double[] arr)
    {
        bool swapped;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }

        return arr;
    }
}