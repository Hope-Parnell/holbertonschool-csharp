using System;
using System.Collections.Generic;

class MatrixMath{
	public static double[,] Add(double[,] matrix1, double[,] matrix2){
		int x0 = matrix1.GetLength(0), x1 = matrix1.GetLength(1), y0 = matrix2.GetLength(0), y1 = matrix2.GetLength(1);
		if(x0 != y0 || x0 != x1 || y0 != y1 || (x0 != 2 && x0 != 3))
			return new double[,] {{-1}};
		var result = new double[x0, x0];
		for (int i = 0; i < x0; i++)
		{
			for (int j = 0; j < x0; j++){
				result[i,j] = matrix1[i,j] + matrix2[i,j];
			}
		}
		return result;
	}
}
