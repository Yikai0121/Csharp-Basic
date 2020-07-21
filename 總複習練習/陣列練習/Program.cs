using System;

namespace 陣列練習
{
    class Program
    {
        static void Main(string[] args)
        {

            //輸入一個整數 N
            //N代表陣列換行
            System.Console.WriteLine("請輸入一個數字");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = Getarraylist();
            for (int i = 0; i < nums.Length; i++)
            {
                System.Console.Write(nums[i] + "\t");
                if ((i + 1) % n == 0)
                {
                    System.Console.WriteLine();
                }
            }
        }

        public static int[] Getarraylist()
        {
            int[] nums = new int[50];
            Random r = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(0, 10);
            }
            return nums;
        }
    }
}
