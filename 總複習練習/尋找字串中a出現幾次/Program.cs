using System;

namespace 尋找字串中a出現幾次
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aaa";
            Countstring(s);

        }
        // 找出字串中'e'的位置有哪些
        //     string str = "adadesesesdfefesdfesfesdesef";
        //     int index = str.IndexOf('e');
        //     System.Console.WriteLine(index);
        //     //循環:從上一次出現e的位置+1的位置找下一次e出現的位置
        //     //循環條件:index != -1   因為找不到會返回-1
        //     int count = 1;
        //     while (index != -1)
        //     {   
        //         count++;
        //         index = str.IndexOf('e',index+1);
        //         if(index==-1){
        //             return;
        //         }
        //         System.Console.WriteLine("第{0}次出現e的位置是{1}",count,index);
        //     }
        public static void Countstring(string s)
        {

            int index = s.IndexOf("a");
            System.Console.WriteLine("第一次出現" + index);
            int i = 1;
            while (index != -1)
            {
                i++;
                index = s.IndexOf("a", index + 1);
                if (index == -1)
                {
                    break;
                }
                System.Console.WriteLine("第{0}次出現e的位置是{1}", i, index);
            }

        }
    }
}
