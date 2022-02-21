using System;

class VectorMath{
    public static double DotProduct(double[] vector1, double[] vector2){
        int l1 = vector1.Length;
        int l2 = vector2.Length;
        if (l1 != l2 || l1 < 2 || l1 > 3)
            return -1;
        double dp = 0;
        for (int i = 0; i < l1; i++)
            dp += vector1[i] * vector2[i];
        return dp;
    }
}
