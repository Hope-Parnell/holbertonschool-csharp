using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] {0, 1, 2, 3};
            jaggedArray[1] = new int[] {0, 1, 2, 3, 4, 5, 6};
            jaggedArray[2] = new int[] {0, 1};
            foreach (var array in jaggedArray)
                Console.WriteLine(String.Join(' ', array));
        }
    }
}
