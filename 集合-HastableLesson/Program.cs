using System;
using System.Collections;

namespace HastableLesson
{
    class Program
    {
        private const string str1 = "是一串繁体中文字，我的电脑要帮翻译";
        private const string str2 = "是一串繁體中文字，我的電腦要幫翻譯";
        static void Main(string[] args)
        {

            //簡體轉繁體練習

            Hashtable ht = new Hashtable();
            for (int i = 0; i < str1.Length; i++)
            {
                ht.Add(str1[i], str2[i]); //建立一個新鍵值對應繁體字 簡體鍵值1 對應繁體值1:我
            }
            Console.WriteLine("請輸入文字");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (ht.ContainsKey(input[i]))
                {
                    System.Console.Write(ht[input[i]]);
                }
                else
                {
                    System.Console.Write(input[i]);
                }
            }




            // Hashtable ht = new Hashtable();
            // ht.Add(1, "First");
            // ht.Add(2, "Second");
            // ht.Add(3, 3);
            // ht.Add(false, "錯誤的");
            // //ht.Add(1,"123"); //鍵值1已有資料 錯誤
            // ht[6] = "新來的";
            // ht[1] = "取代First"; //重新賦值

            // ht.Clear(); //移除集合元素
            // ht.Remove(2);//移除鍵值2的值 Second
            // if (ht.ContainsKey("false")) //判斷是否有鍵值 false 的值
            // {


            // }

            // foreach (var item in ht.Keys)
            // {
            //     System.Console.WriteLine("鍵-----{0}=======值是{1}", item, ht[item]);
            // }





            //     //再鍵值對集合中，是根據鍵去找值的
            //     System.Console.WriteLine(ht[1]);
            //     System.Console.WriteLine(ht[2]);
            //     System.Console.WriteLine(ht[3]);
            //     System.Console.WriteLine(ht[false]);

            //     System.Console.WriteLine("========================");
            //     for (int i = 0; i < ht.Count; i++)
            //     {
            //         System.Console.WriteLine(ht[i]);
            //     }
        }
    }
}
