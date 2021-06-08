using System;

namespace _1_TwoSum
{
    class Program
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        ///You can return the answer in any order.
        /// Array içinden seçilen iki elemanın toplamının , hedefte ki sayıya eşit olma durumun
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 7, 13, 15 };

            int target = 28;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine("nums[" + i + "] ile nums[" + j + "] toplamı"+" "+target+"'e eşit.");
                    }
                }
            }
        }
    }
}
