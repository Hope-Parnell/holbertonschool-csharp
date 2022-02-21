using System;
using System.Collections.Generic;

class VectorMath{
    public static double[] Add(double[] vector1, double[] vector2){
        int l1 = vector1.Length;
        int l2 = vector2.Length;
        if (l1 != l2 || l1 < 2 || l1 > 3)
            return new double[] {-1};
        var list = new List<double>();
        for (int i = 0; i < l1; i++)
            list.Add(vector1[i] + vector2[i]);
        return list.ToArray();
    }
}
