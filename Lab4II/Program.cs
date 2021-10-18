using System;

namespace Lab4II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        ///     Checks if the 2D array is both a square and contains only diagonal elements.
        ///     Non-diagonal elements are 0 while diagonal elements are not 0.
        /// </summary>
        /// <param name="data">the 2D array passed in to be checked</param>
        /// <returns>true if the array is a square and contains only diagonal elements. Otherwise, false.</returns>
        public Boolean IsDiagonal(int[,] data)
        {
            if (data.GetLength(0) == data.GetLength(1))
            {
                if (data[0, 0] == 0) return false;
                if (data[0, data.GetLength(1) - 1] == 0) return false;
                if (data[data.GetLength(0) - 1, 0] == 0) return false;
                if (data[data.GetLength(0) - 1, data.GetLength(1) - 1] == 0) return false;
                return true;
            }
            return false;
        }

        /// <summary>
        /// This function takes 2D array, adds all Xs and Ys and returns a single array with two numbers
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int[] RowSum(int[,] data)
        {
            int[] newArray = new int[2];
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (j == 0) newArray[0] = newArray[0] + data[i, j];
                    if (j == 1) newArray[1] = newArray[1] + data[i, j];
                }
            }
            return newArray;
        }

        /// <summary>
        /// Prints each row's sum
        /// </summary>
        /// <param name="data">the 2D array's sums to be printed</param>
        public static void PrintRowSums(int[] data)
        {
            for (int index = 0; index < data.Length; index++)
            {
                Console.WriteLine("Row {0} sum: {1}", index, data[index]);
            }
        }
    }
}
