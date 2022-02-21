using System;
using System.Collections.Generic;

class MatrixMath{
    public static double[,] Inverse2D(double[,] matrix){
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,]{{-1}};
        double x = Determinant(matrix);
        if (x == 0)
            return new double[,]{{-1}};
        double[,] ret = new double[2,2];
        ret[0,0] = Math.Round(matrix[1,1] / x, 2);
        ret[0,1] = Math.Round(matrix[0,1] / -x, 2);
        ret[1,0] = Math.Round(matrix[1,0] / -x, 2);
        ret[1,1] = Math.Round(matrix[0,0] / x, 2);
        return ret;

    }
    static double Determinant(double[,] matrix){
        int x = matrix.GetLength(0), y = matrix.GetLength(1);
        if( (x != y) || (x != 2 && x != 3))
            return -1;
        if (x == 2){
            double result = (matrix[0,0] * matrix[1, 1]) - (matrix[1, 0] * matrix[0,1]);
            return Math.Round(result, 2);
        }
        else {
            double aei = matrix[0,0] * matrix[1,1] * matrix[2,2];
            double bfg = matrix[1,0] * matrix[2,1] * matrix[0,2];
            double cdh = matrix[2,0] * matrix[0,1] * matrix[1,2];
            double afh = matrix[0,0] * matrix[2,1] * matrix[1,2];
            double bdi = matrix[1,0] * matrix[0,1] * matrix[2,2];
            double ceg = matrix[2,0] * matrix[1,1] * matrix[0,2];

            double result = aei + bfg + cdh - afh - bdi - ceg;
            return Math.Round(result, 2);

        }
    }
}
