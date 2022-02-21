using System;


class VectorMath{
    /// <summary>Calulates the length of a vector.</summary>
    public static double Magnitude(double[] vector){
        if (vector == null || vector.Length < 2 || vector.Length > 3)
            return -1;
        double add = 0;
        foreach(double n in vector){
            add += n * n;
        }
        return Math.Round(Math.Sqrt(add), 2);
    }
}
