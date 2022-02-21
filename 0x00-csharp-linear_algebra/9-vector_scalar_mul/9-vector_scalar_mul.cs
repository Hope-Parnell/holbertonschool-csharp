using System;
using System.Collections.Generic;

class VectorMath{
    public static double[] Multiply(double[] vector, double scalar){
        if (vector.Length < 2 || vector.Length > 3)
            return new double[] {-1};
        var list = new List<double>();
        foreach (double n in vector)
            list.Add(n*scalar);
        return list.ToArray();
    }
}
