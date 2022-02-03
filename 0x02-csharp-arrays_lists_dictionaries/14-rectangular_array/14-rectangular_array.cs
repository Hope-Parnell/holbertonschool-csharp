using System;
using System.Collections.Generic;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[5,5];
            array2D[2,2] = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j < 4)
                        Console.Write("{0} ", array2D[i,j]);
                    else
                        Console.WriteLine(array2D[i,j]);
                }
            }
        }
    }
}
