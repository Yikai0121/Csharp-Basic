using System;

namespace 指定陣列儲存30個學生成績並給予隨機值求出平均成績
{
    class Program
    {
        static void Main(string[] args)
        {
           int n  = SumAvg();
           System.Console.WriteLine(n);
        }
        public static int SumAvg()
        {
            Random r = new Random();
            int [] n = new int[30];
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = r.Next(0, 101);
                System.Console.WriteLine(n[i]);
            }
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            System.Console.WriteLine(sum);
            return sum / n.Length;
        }
    }
}
