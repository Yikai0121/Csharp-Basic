using System;

namespace 計算整數數列平均組並顯示小數點後兩位
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] nums = { 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 };
            
            double avg = AvgSum(nums);
            string s = avg.ToString("0.00");
            avg = Convert.ToDouble(s);
            System.Console.WriteLine(avg);

        }

        public static double AvgSum(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                
            }
            double avg = sum/nums.Length;
            return avg;
        }
        
    }
}
