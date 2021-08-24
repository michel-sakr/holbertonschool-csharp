using System;


class VectorMath
{
    /// <summary>
    /// method to calculate cross product
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns>cross product</returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 3 && vector2.Length == 3)
        {
            double x = vector1[1] * vector2[2] - vector1[2] * vector2[1];
            double y = vector1[2] * vector2[0] - vector1[0] * vector2[2];
            double z = vector1[0] * vector2[1] - vector1[1] * vector2[0];
            double[] vec = new double[] { x, y, z };
            return vec;
        }
        else
        {
            double[] min1 = new double[] { -1 };
            return min1;

        }
    }
}