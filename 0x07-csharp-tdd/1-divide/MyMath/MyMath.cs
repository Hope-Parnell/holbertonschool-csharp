using System;

namespace MyMath
{
    /// <summary>Contains operations using matricies.</summary>
    public class Matrix
    {
        /// <summary>Returns a new matrix whose contents is the original matrix divided by a number</summary>
        public static int[,] Divide(int[,] matrix, int num){
            if (num == 0) {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            if (matrix == null) { return null; }
            int x = matrix.GetLength(0);
            int y = matrix.GetLength(1);
            int[,] result = new int[x,y];
            for (int i = 0; i < x; i++){
                for (int j = 0; j < y; j++)
                    result[i,j] = matrix[i,j] / num;
            }
            return result;
        }
    }
}
