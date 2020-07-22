using System;
using System.Collections.Generic;

namespace 計算字串中字出現的次數
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Welcome to Taiwan";

            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    continue;
                }
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]]++;
                }
                else
                {
                    dic[s[i]] = 1;
                }
            }
            foreach (KeyValuePair<char, int> item in dic)
            {
                System.Console.WriteLine("字母{0}出現了{1}次", item.Key, item.Value);
            }
        }
    }
}
