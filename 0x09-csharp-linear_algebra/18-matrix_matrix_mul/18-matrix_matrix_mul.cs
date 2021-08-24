using System;

class MatrixMath {
    /// <summary>
    /// method to multiply 2 matrices
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns>multiplication</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(1) == matrix2.GetLength(0))
        {
            int row = matrix1.GetLength(0);
            int col1 = matrix1.GetLength(1);
            int col2 = matrix2.GetLength(1);
            double[,] mult = new double[row, col2];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    double count = 0;
                    for (int k = 0; k < col1; k++)
                    {
                        count += matrix1[i, k] * matrix2[k, j];

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