using System;

namespace 字串轉換練習
{
    class Program
    {
        static void Main(string[] args)

        //輸入一串英文將第一個字轉為小寫
        {
            System.Console.WriteLine("請輸入英文");
            string input = Console.ReadLine();
            System.Console.WriteLine(Lowcontext(input));;
        }


        public static string Lowcontext(string n)
        {
            return n.Substring(0, 1).ToLower()+n.Substring(1,n.Length-1);
        }
    }
}
