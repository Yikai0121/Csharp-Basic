using System;
using System.Collections.Generic;
using System.Linq;

namespace 泛型集合練習
{
    class Program
    {
        static void Main(string[] args)
        {
            //將一個數組中的奇數放到一個集合中，在將偶數放到另一個集合中
            //最終將兩個集合合併為一個集合，並且奇數在左邊 偶數顯示在右邊
            // int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // List<int> num1 = new List<int>();
            // List<int> num2 = new List<int>();
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     if (nums[i] % 2 == 0)
            //     {
            //         num1.Add(nums[i]);
            //     }
            //     else
            //     {
            //         num2.Add(nums[i]);
            //     }
            // }
            // num2.AddRange(num1);
            // foreach (var item in num2)
            // {
            //     System.Console.Write(item);
            // }


            //提示用戶輸入一個字串，通過foreach循環將用戶輸入的字串賦值給一個陣列

            // Console.WriteLine("請輸入字串");
            // string input = Console.ReadLine();
            // char[] ch = new char[input.Length];
            // int i = 0;
            // foreach (var item in input)
            // {
            //     ch[i] = item;
            //     i++;
            // }

            //統計 Welcome to Taiwan 中每個單字出現的次數，不考慮大小寫
            //字符-------次數  w-----1 e--1 c--1
            //鍵---------值
            string str = "Welcome to Taiwan";
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ') { continue; }
                if (dic.ContainsKey(str[i]))
                {
                    dic[str[i]]++;
                }
                else
                {
                    dic[str[i]] = 1;
                }
            }
            foreach(KeyValuePair<char,int> item in dic){
                System.Console.WriteLine("{0} --- {1}",item.Key,item.Value);
            }




        }
    }
}
