using System;

namespace 計算1_100整數和和奇數和
{
    class Program
    {
        static void Main(string[] args)
        {
            NumSum();
            Oddnum();
        }
        public static void NumSum()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            System.Console.WriteLine(sum);
        }
        public static void Oddnum()
        {   
            int sum = 0;
            for (int i = 1; i <=100; i+=2)
            {   
                sum +=i;
            }
            System.Console.WriteLine(sum);
        }
    }
}
