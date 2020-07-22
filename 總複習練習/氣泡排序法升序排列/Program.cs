using System;

namespace 氣泡排序法升序排列
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            Bobble(num);

        }
        public static void Bobble(int[] nums)
        {
            /*
            [10]
            1st 9  i = 0 j = num.length-i-1
            2nd 8  i = 1 j = num.length-i-1
            3rd 7
            */
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = 0; j < nums.Length - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }

            }
            foreach (var item in nums)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
