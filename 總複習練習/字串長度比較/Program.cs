using System;

namespace 字串長度比較
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "馬龍", "麥克喬丹", "雷吉米勒", "蒂姆鄧肯", "柯比布萊恩" };
            System.Console.WriteLine(StrMax(str)); 
        }
        public static string StrMax(string[] str)
        {
            string Max = str[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length>Max.Length)
                {
                    Max = str[i];
                }
            }
            return Max;
        }
    }
}
