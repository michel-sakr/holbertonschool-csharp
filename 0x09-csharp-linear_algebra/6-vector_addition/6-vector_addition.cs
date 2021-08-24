using System;

class VectorMath
{
    /// <summary>
    /// Adds two vectors
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns>vector</returns>
    public static double[] Add(double[] vector1, double[] vector2) {
        double[] result;
        if(vector1.Length == 2 && vector2.Length == 2) {
            result = new double[2];
            result[0] = vector1[0]+vector2[0];
            result[1] = vector1[1]+vector2[1];
            return result;
        } else if(vector1.Length == 3 && vector2.Length == 3) {
            result = new double[3];
            result[0] = vector1[0]+vector2[0];
            result[1] = vector1[1]+vector2[1];
            result[2] = vector1[2]+vector2[2];
            return result;
        }
        else
        result = new double[1];
        result[0] = -1;
        return result;
    }
}
