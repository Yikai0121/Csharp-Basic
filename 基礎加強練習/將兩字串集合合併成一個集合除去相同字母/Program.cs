using System;
using System.Collections.Generic;

namespace 將兩字串集合合併成一個集合除去相同字母
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOne = new List<string>() { "a", "b", "c", "d", "e" };
            List<string> listTwo = new List<string>() { "d", "e", "f", "g", "h" };

            for (int i = 0; i < listTwo.Count; i++)
            {
                if (!listOne.Contains(listTwo[i]))
                {
                    listOne.Add(listTwo[i]);
                }
            }
            foreach (var item in listOne)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
