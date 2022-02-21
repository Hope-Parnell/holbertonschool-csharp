using System;
using System.Collections.Generic;

class MatrixMath{
	public static double[,] MultiplyScalar(double[,] matrix, double scalar){
		int x0 = matrix.GetLength(0), x1 = matrix.GetLength(1);
		if (x0 != x1 || x0 < 2 || x0 > 3)
			return new double[,] {{-1}};
		var result = new double[x0, x0];
		for (int i = 0; i < x0; i++)
		{
			for (int j = 0; j < x0; j++){
				result[i,j] = matrix[i,j] * scalar;
			}
		}
		return result;
	}
}
