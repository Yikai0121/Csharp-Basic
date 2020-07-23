using System;

namespace 委託練習
{
    public delegate int Delcompare(object o1, object o2);
    class Program
    {

        static void Main(string[] args)
        {
            object[] numbers = { 1, 8, 6, 5, 4, 8, 6, 3, 2, 5, 5, 5 };
            object Max = GetMax(numbers, delegate (object o1, object o2)
            {
                int n1 = (int)o1;
                int n2 = (int)o2;
                return n1 - n2;
            });
            // object Max = GetMax(numbers, (object o1, object o2) =>
            // {
            //     int n1 = (int)o1;
            //     int n2 = (int)o2;
            //     return n1 - n2;

            // });
            System.Console.WriteLine(Max);
        }
        public static object GetMax(object[] num, Delcompare del)
        {
            object Max = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                //傳一個方法
                if (del(Max, num[i]) < 0)
                {
                    Max = num[i];
                }
            }
            return Max;
        }
    }
}
