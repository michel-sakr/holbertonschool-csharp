using System;

class MatrixMath
{
    /// <summary>
    /// method to rotate matrix by angle
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="angle"></param>
    /// <returns>rotation</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double[,] mat = new double[2, 2];
            double cos = Math.Cos(angle);
            double sin = Math.Sin(angle);
            double[,] rot = new double[,]{
                {cos,sin},
                {-sin,cos}
            };
            int row = matrix.GetLength(0);
            int col1 = matrix.GetLength(1);
            int col2 = rot.GetLength(1);
            double[,] mult = new double[row, col2];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    double count = 0;
                    for (int k = 0; k < col1; k++)
                    {
                        count = Math.Round(count + matrix[i, k] * rot[k, j], 2);

                    }
                    mult[i, j] = count;
                }
            }
            return mult;
        }

        else
        {
            double[,] min1 = { { -1 } };
            return min1;
        }

    }
}
