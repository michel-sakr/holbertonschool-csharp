using System;

class MatrixMath {
    public static double[,] MultiplyScalar(double[,] matrix, double scalar) {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double[,] mult2 = {
                {0,0},
                {0,0}
            };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    mult2[i, j] = matrix[i, j] * scalar;
                }
            }
            return mult2;
        }
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            double[,] mult3 = {
                {0,0,0},
                {0,0,0},
                {0,0,0}

            };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    mult3[i, j] = matrix[i, j] * scalar;
                }
            }
            return mult3;
        }
        else
        {
            double[,] min1 = { { -1 } };
            return min1;
        }
    }
}
