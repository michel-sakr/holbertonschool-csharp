using System;


class MatrixMath
{
    /// <summary>
    /// method to get inverse a 2d matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns>inversed matrix</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double det = matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1];
            if (det == 0)
            {
                double[,] min1 = { { -1 } };
                return min1;
            }
            double[,] inv = new double[,]{
                {Math.Round((1 / det)*matrix[1,1],2),-Math.Round((1 / det)*matrix[0,1],2)},
                {-Math.Round((1 / det)*matrix[1,0],2),Math.Round((1 / det)*matrix[0,0],2)}
            };
            return inv;
        }
        else
        {
            double[,] min1 = { { -1 } };
            return min1;
        }

    }
}