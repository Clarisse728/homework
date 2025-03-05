using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 示例矩阵
        int[,] matrix = {
            {1, 2, 3, 4},
            {5, 1, 2, 3},
            {9, 5, 1, 2}
        };

        bool isToeplitz = IsToeplitzMatrix(matrix);
        Console.WriteLine("矩阵是否是托普利茨矩阵？{0}", isToeplitz);
    }

    static bool IsToeplitzMatrix(int[,] matrix)
    {
        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
        {
            return true;
        }

        Dictionary<int, int> dict = new Dictionary<int, int>();

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int key = i - j;

                if (!dict.ContainsKey(key))
                {
                    dict[key] = matrix[i, j];
                }
                else
                {
                    if (dict[key] != matrix[i, j])
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }
}
