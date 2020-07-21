using System;

namespace 計算任意數個數最大值
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine(Max(1,8,5,4,2,3,3,6,5,2,1,1,2,100,2));
        }

        public static int Max(params int[] nums)
        {
            int Max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > Max)
                {
                    Max = nums[i];
                }
            }
            return Max;
        }
    }
}
