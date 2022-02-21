using System;
using System.Collections.Generic;

class MatrixMath{
    public static double Determinant(double[,] matrix){
        int x = matrix.GetLength(0), y = matrix.GetLength(1);
        if( (x != y) || (x != 2 && x != 3))
            return -1;
        if (x == 2){
            double ans = (matrix[0,0] * matrix[1, 1]) - (matrix[1, 0] * matrix[0,1]);
            return Math.Round(ans, 2);
        }
        else {
            double aei = matrix[0,0] * matrix[1,1] * matrix[2,2];
            double bfg = matrix[1,0] * matrix[2,1] * matrix[0,2];
            double cdh = matrix[2,0] * matrix[0,1] * matrix[1,2];
            double afh = matrix[0,0] * matrix[2,1] * matrix[1,2];
            double bdi = matrix[1,0] * matrix[0,1] * matrix[2,2];
            double ceg = matrix[2,0] * matrix[1,1] * matrix[0,2];

            double ans = aei + bfg + cdh - afh - bdi - ceg;
            return Math.Round(ans, 2);

        }
    }
}
