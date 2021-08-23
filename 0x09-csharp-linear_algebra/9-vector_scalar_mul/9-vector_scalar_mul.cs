using System;


    class VectorMath
    {
        public static double[] Multiply(double[] vector, double scalar) {
             double[] result;
        if(vector.Length == 2) {
            result = new double[2];
            result[0] = vector[0] * scalar;
            result[1] = vector[1] * scalar;
            return result;
        } else if(vector.Length == 3) {
            result = new double[3];
            result[0] = vector[0] * scalar;
            result[1] = vector[1] * scalar;
            result[2] = vector[2] * scalar;
            return result;
        }
        else
        result = new double[1];
        result[0] = -1;
        return result;
        }
    }

