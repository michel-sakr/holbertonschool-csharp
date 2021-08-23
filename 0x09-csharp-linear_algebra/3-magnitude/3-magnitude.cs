using System;

class VectorMath {
    public static double Magnitude(double[] vector) {
        if(vector.Length == 2) {
            return Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + (Math.Pow(vector[1], 2))), 2);
        }
        else if(vector.Length == 3) {
            double v1 = Math.Sqrt(Math.Pow(vector[0], 2) + (Math.Pow(vector[1], 2)));
            return Math.Round(Math.Sqrt(Math.Pow(v1, 2) + (Math.Pow(vector[2], 2))), 2);
        }
        else return -1;
    }
}