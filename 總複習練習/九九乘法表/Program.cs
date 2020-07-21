using System;

namespace 九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninenine();
        }

        public static void Ninenine()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    System.Console.Write("{0} X {1} = {2} ", i, j, i * j);
                }
                System.Console.WriteLine();
            }
        }
        
    }
}
