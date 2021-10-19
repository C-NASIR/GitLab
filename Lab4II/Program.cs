using System;

namespace Lab4II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] _MultiDimentionArray = new int[4, 2] { { 0, 1 }, { 1, 2 }, { 2, 3 }, { 3, 4 } };
            PrintRowSums(RowSum(_MultiDimentionArray));
        }

        /// <summary>
        /// Checks if the 2D array is both a square and contains only diagonal elements.
        /// Non-diagonal elements are 0 while diagonal elements are not 0.
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
        /// This function takes 2D array, adds all rows and returns a single array with row sums
        /// </summary>
        /// <param name="data">the 2D array</param>
        /// <returns>a 1D array containing the sums</returns>
        public static int[] RowSum(int[,] data)
        {
            int[] newArray = new int[data.GetLength(0)];
            for (int i = 0; i < data.GetLength(0); i++)
                newArray[i] = data[i, 0] + data[i, 1];
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
