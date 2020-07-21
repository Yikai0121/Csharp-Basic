using System;

namespace 判斷是否質數且算出1_100質數總和
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = Primenumber(131);
            System.Console.WriteLine(b);
            int sum = PrimenumberSum();
            System.Console.WriteLine(sum);
        }
        public static bool Primenumber(int n)
        {
            if (n < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public static int PrimenumberSum()
        {

            int sum = 0;
            for (int i = 2; i <= 100; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    sum += i;
                }

            }
            return sum;
        }
    }
}
