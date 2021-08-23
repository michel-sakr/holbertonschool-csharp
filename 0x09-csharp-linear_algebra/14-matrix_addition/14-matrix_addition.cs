using System;


class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2) {
        if (matrix1.GetLength(0) == 2 && matrix2.GetLength(0) == 2 && matrix1.GetLength(1) == 2 && matrix2.GetLength(1) == 2)
        {
            double[,] add2 = {
                {0,0},
                {0,0}
            };
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(0); j++)
                {
                    add2[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return add2;
        }
        else if (matrix1.GetLength(0) == 3 && matrix2.GetLength(0) == 3 && matrix1.GetLength(1) == 3 && matrix2.GetLength(1) == 3)
        {
            double[,] add3 = {
                {0,0,0},
                {0,0,0},
                {0,0,0}
            };
            for (int i = 0; i < add3.GetLength(0); i++)
            {
                for (int j = 0; j < add3.GetLength(0); j++)
                {
                    add3[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return add3;
        }
        else
        {
            double[,] min1 = { { -1 } };
            return min1;

        }

    }
}

