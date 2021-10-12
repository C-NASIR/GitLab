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
    }
}
