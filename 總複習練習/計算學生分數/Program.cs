using System;

namespace One
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("輸入分數");
                int input = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine(GetScore(input));
            }
            catch 
            {

                System.Console.WriteLine("請輸入整數數字");
            }



        }


        public static string GetScore(int score)
        {

            string str = null;
            switch (score % 10)
            {
                case 0:
                case 9:
                    str = "優";
                    break;
                case 8:
                    str = "良";
                    break;
                case 7:
                    str = "佳";
                    break;
                case 6:
                    str = "中";
                    break;
                default:
                    str = "差";
                    break;
            }
            return str;
        }
    }
}
