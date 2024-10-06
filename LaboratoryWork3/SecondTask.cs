namespace LaboratoryWork3;

class SecondTask
{
    public static void PrintMatrix(int[,] matrix, int rows, int columns)
    {
        for (int k = 0; k < rows; k++)
        {
            Console.WriteLine();
            for (int d = 0; d < columns; d++)
            {
                Console.Write(matrix[k, d] + "\t");
            }
        }
    }

    public static void GetSumOfRowsWithNegative(int[,] arr, int rows, int columns)
    {
        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < columns; j++)
            {
                if (arr[i, j] < 0)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        sum += arr[i, k];
                    }

                    j = columns;
                }

                if (sum != 0)
                {
                    Console.WriteLine($"Сумма в {i} строке, где есть отрицательный(-е) элемент(-ы): {sum}");
                }
            }
        }
        
    }

    public static void FindSedlPoints(int[,] arr, int rows, int columns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (IsMinInRow(arr, i, j,columns) && IsMaxInColumn(arr, i, j,  rows))
                {
                    Console.WriteLine($"[{i}, {j}]");
                }
            }
        }
    }

    public static bool IsMinInRow(int[,] arr, int rowInd, int columnInd, int maxCol)
    {
        bool isMin;
        int min = 10000;
        for (int i = 0; i < maxCol; i++)
        {
            if (arr[rowInd, i] < min)
            {
                min = arr[rowInd, i];
            }
        }

        if (min == arr[rowInd, columnInd])
        {
            isMin = true;
        }
        else
        {
            isMin = false;
        }
        
        return isMin;
    }

    public static bool IsMaxInColumn(int[,] arr, int rowInd, int columnInd, int maxRow)
    {
        bool isMax;
        int max = 0;
        for (int i = 0; i < maxRow; i++)
        {
            if (arr[i, columnInd] > max)
            {
                max = arr[i, columnInd];
            }
        }

        if (max == arr[rowInd, columnInd])
        {
            isMax = true;
        }
        else
        {
            isMax = false;
        }

        return isMax;
    }
}