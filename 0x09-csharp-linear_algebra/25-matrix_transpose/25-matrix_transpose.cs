using System;

class MatrixMath
{
    /// <summary>
    /// method to transpose a matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns>transposed</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
        {
            return new double[,] { };
        }
        int col = matrix.GetLength(0);
        int row = matrix.GetLength(1);
        double[,] trans = new double[row, col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                trans[i, j] = matrix[j, i];
            }
        }
        return trans;
    }
}