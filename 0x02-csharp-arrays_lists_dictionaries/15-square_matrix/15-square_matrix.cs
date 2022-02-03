using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int x = myMatrix.GetLength(0);
        int y = myMatrix.GetLength(1);
        var squareMatrix = new int[x,y];
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
                squareMatrix[i,j] = myMatrix[i,j] * myMatrix[i,j];
        }
        return squareMatrix;
    }
}
