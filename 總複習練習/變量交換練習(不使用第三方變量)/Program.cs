using System;

namespace 變量交換練習_不使用第三方變量_
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1 = 10;
           int n2 = 20;
           Changeint(ref n1,ref n2);
           System.Console.WriteLine(n1);
           System.Console.WriteLine(n2);

        }
        public static void Changeint(ref int n1, ref int n2)
        {
            n1 = n1 - n2;
            n2 = n1 + n2;
            n1 = n2 - n1;

        }
    }
}
