using System;

namespace 計算任意數個數最大值
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Max(1, 8, 5, 4, 2, 3, 3, 6, 5, 2, 1, 1, 2, 100, 2));
            System.Console.WriteLine(Max2(10, 50));
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
        //比較兩數
        public static int Max2(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
    }
}
