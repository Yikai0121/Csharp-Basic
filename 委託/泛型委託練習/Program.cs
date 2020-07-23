using System;

namespace 泛型委託練習
{
    public delegate int Delcompare<T>(T t1, T t2);
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            string[] str = { "sdfasfd", "sdkdksd", "sdfkljaslkdfjl" };
            int Maxnumber = GetMax<int>(numbers, (int t1, int t2) =>
            {
                return t1 - t2;
            });
            System.Console.WriteLine(Maxnumber);

            string Maxstr = GetMax<string>(str, (string t1, string t2) =>
            {
                return t1.Length-t2.Length;
            });
            System.Console.WriteLine(Maxstr);
        }

        public static T GetMax<T>(T[] n, Delcompare<T> del)
        {
            T Max = n[0];
            for (int i = 0; i < n.Length; i++)
            {
                if (del(Max, n[i]) < 0)
                {
                    Max = n[i];
                }
            }
            return Max;
        }
    }
}
