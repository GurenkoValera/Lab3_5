using System;

class Program
{
    static void Main()
    {
        // Инициализация двумерных матриц 5x5
        int[,] matrix1 = {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { 16, 17, 18, 19, 20 },
            { 21, 22, 23, 24, 25 }
        };

        int[,] matrix2 = {
            { 25, 24, 23, 22, 21 },
            { 20, 19, 18, 17, 16 },
            { 15, 14, 13, 12, 11 },
            { 10, 9, 8, 7, 6 },
            { 5, 4, 3, 2, 1 }
        };

        // Перемножение матриц
        int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

        // Вывод результата
        Console.WriteLine("Результат перемножения матриц:");
        PrintMatrix(resultMatrix);
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int size = 5; // Размер матриц 5x5
        int[,] result = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                result[i, j] = 0; // Инициализация элемента результата
                for (int k = 0; k < size; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}