using System;
using System.Collections.Generic;
using System.Linq;

namespace ListTLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.AddRange(new int []{1,2,3,5,4,6,8,7,9});
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }

            //泛型集合可以轉成陣列
           int [] nums =  list.ToArray();

            //陣列也可以轉成泛型集合
           char [] chr = new char[]{'1','4','b'};
           List<char> listchar = chr.ToList();
           foreach (var item in listchar)
           {
               System.Console.WriteLine(item);
           }
        }
    }
}
