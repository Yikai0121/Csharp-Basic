using System;

namespace 字串前後去空格再將每字以空格隔開輸出
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "     Hello    world   ,你   好  世   界     !";
            System.Console.WriteLine(Str(s));
        }
        public static string Str(string s)
        {
            s.Trim();
            string[] news = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string str = string.Join(" ", news);
            return str;

        }
    }
}
