using System;
using System.Collections.Generic;

namespace DictionaryLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dic = new Dictionary<int, string>();
            dic.Add(1,"First");
            dic.Add(2,"Second");
            // dic.Add(1,"123"); //同鍵值 報異常
            // dic[1] = "取代Firt"; //賦值 不會異常

            foreach (KeyValuePair<int,string> item in dic)
            {
                System.Console.WriteLine("{0}--------{1}",item.Key,item.Value);
            }

        }
    }
}
