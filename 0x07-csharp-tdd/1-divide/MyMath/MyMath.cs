using System;

namespace MyMath
{
    /// <summary>
    /// This class defines operations for a matrix
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Method that divides all elements of a matrix.
        /// <param name="matrix">matrix of integers (int[,])</param>
        /// <param name="num">divisor</param>
        /// <returns>a new matrix containing divided elements</returns>
        /// </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            int[,] newMatrix;

            try
            {
                newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                    for(int j = 0; j < matrix.GetLength(1); j++)
                    {
                        newMatrix[i, j] = matrix[i, j] / num;
                    }
                }
            }
            catch (NullReferenceException) // when matrix is null (line 22)
            {
                return null;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            return newMatrix;
        }
    }
}
