using System;

namespace 字串比對練習
{
    class Program
    {
        static void Main(string[] args)
        {
            //比對字串 
            System.Console.WriteLine("A喜歡的語言");
            string s1 = Console.ReadLine();
            //s1 = s1.ToUpper();轉換為相同大小寫
            //s1 = s1.ToLower();
            System.Console.WriteLine("B喜歡的語言");
            string s2 = Console.ReadLine();
            //s2 = s2.ToUpper();轉換為相同大小寫
            //s2 = s2.ToLower();

            if (s1.Equals(s2, StringComparison.OrdinalIgnoreCase))//比較兩個字串的值
            {
                Console.WriteLine("你們喜歡相同的語言");
            }
            else
            {
                System.Console.WriteLine("你們喜好不同");
            }
        }
    }
}
