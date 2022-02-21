using System;
using System.Collections.Generic;

class MatrixMath{
    public static double[,] Transpose(double[,] matrix){
        if (matrix == null || matrix.Length == 0)
            return new double[,]{};
        double[,] result = new double[matrix.GetLength(1), matrix.GetLength(0)];
        for (int i = 0; i < result.GetLength(0); i++){
            for (int j = 0; j < result.GetLength(1); j++){
                result[i, j] = matrix[j, i];
            }
        }
        return result;
    }
}
