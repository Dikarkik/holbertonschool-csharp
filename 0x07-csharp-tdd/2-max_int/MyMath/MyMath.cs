using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// This class defines operations for a List<int>
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Method that divides all elements of a matrix
        /// <param name="nums">list of integers (List<int>)</param>
        /// <returns>max integer in list, If nums is empty, return 0</returns>
        /// </summary>
        public static int Max(List<int> nums)
        {
            int maxInteger;

            try
            {
                maxInteger = nums[0];

                for (int i = 0; i < nums.Count; i++)
                { 
                    if (nums[i] > maxInteger)
                        maxInteger = nums[i];
                }
            }
            catch (NullReferenceException) // nums is null
            {
                return 0;
            }
            catch (ArgumentOutOfRangeException) // List is empty
            {
                return 0;
            }

            return maxInteger;
        }
    }
}
