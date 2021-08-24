using System;


class MatrixMath
{
    /// <summary>
    /// method to calculate determinant of a matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns>determinant</returns>
    public static double Determinant(double[,] matrix)
    {
        double deter = 0;
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            deter = (Math.Round(matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0], 2));
            return deter;
        }

        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            double x = matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1];
            double y = matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0];
            double z = matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0];
            deter = (Math.Round(matrix[0, 0] * x - matrix[0, 1] * y + matrix[0, 2] * z, 2));
            return deter;
        }
        else return -1;

    }
}