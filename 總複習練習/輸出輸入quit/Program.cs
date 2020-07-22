using System;
using System.Collections.Generic;

namespace 輸出輸入quit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            while (true)
            {
                Console.WriteLine("請輸入姓名,離開請輸入quit");
                string input = Console.ReadLine();
                if (input != "quit")
                {
                    list.Add(input);
                }
                else
                {
                    break;
                }

            }
            System.Console.WriteLine("您輸入了{0}個學生 分別為", list.Count);
            int i = 0;
            foreach (var item in list)
            {
                
                if (item[0] == '王')
                {
                    i++;
                }

                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("姓王的有{0}個", i);

        }
    }
}
