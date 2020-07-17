using System;
using System.IO;
using System.Text;

namespace StringPracticeFinal
{
    class Program
    {
        static void Main(string[] args)
        {

            // //把{"諸葛亮","鳥叔","卡卡西","卡哇伊"}變成 諸葛亮|鳥叔|卡卡西|卡哇伊，再把|切割掉
            // string[] names = { "諸葛亮", "鳥叔", "卡卡西", "卡哇伊" };
            // string newnames = string.Join("|", names);
            // System.Console.WriteLine(newnames);
            // string[] nameV2 = newnames.Split('|', StringSplitOptions.RemoveEmptyEntries);
            // foreach (var item in nameV2)
            // {
            //     System.Console.WriteLine(item);
            // }



            // //用戶輸入一句話，判斷這句話有無邪惡，如果有邪惡替換成**，ex:老牛很邪惡---老牛很**
            // string str = "老牛很邪惡";
            // if (str.Contains("邪惡"))
            // {
            //     str = str.Replace("邪惡", "**");
            // }
            // System.Console.WriteLine(str);

            //找出字串中'e'的位置有哪些
            //string str = "adadesesesdfefesdfesfesdesef";
            // int index = str.IndexOf('e');
            // System.Console.WriteLine(index);
            // //循環:從上一次出現e的位置+1的位置找下一次e出現的位置
            // //循環條件:index != -1   因為找不到會返回-1
            // int count = 1;
            // while (index != -1)
            // {   
            //     count++;
            //     index = str.IndexOf('e',index+1);
            //     if(index==-1){
            //         return;
            //     }
            //     System.Console.WriteLine("第{0}次出現e的位置是{1}",count,index);
            // }




            // //讀取檔案將空白去除，作品名|作者，超過八個字變成作品...
            // string path = @"C:\Users\user\Desktop\1.txt";
            // string[] contents = File.ReadAllLines(path, Encoding.Default);
            // for (int i = 0; i < contents.Length; i++)
            // {
            //     string[] newcontents = contents[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //     Console.WriteLine(newcontents[0].Length > 10 ? newcontents[0].Substring(0, 8)+"....." : newcontents[0] + "|" + newcontents[1]);
            // }




            //Email中提取用戶名和域名 k2lairrol@gmail.com
            string email = "k2lairrol@gmail.com";
            string name = email.Substring(0,email.IndexOf('@',1));
            string lastname = email.Substring(email.IndexOf('@',1)+1);
            System.Console.WriteLine(name);
            System.Console.WriteLine(lastname);


            // //將 hello c sharp 轉換成 sharp c hello
            // string str = "hello c sharp";
            // string[] newstr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            // for (int i = 0; i < newstr.Length / 2; i++)
            // {
            //     string temp = newstr[0];
            //     newstr[0] = newstr[newstr.Length - 1 - i];
            //     newstr[newstr.Length - i - 1] = temp;
            // }
            // str = string.Join(" ", newstr);
            // Console.WriteLine(str);



            // //將字串反轉
            // string str = "abfsfasdf";
            // char [] newchar =str.ToCharArray();
            // for (int i = 0; i < newchar.Length/2; i++)
            // {
            //     char temp = newchar[i];
            //     newchar[i] = newchar[newchar.Length-i-1];
            //     newchar[newchar.Length-i-1] = temp;
            // }
            //     str = new string(newchar);
            //     System.Console.WriteLine(str);
        }
    }
}
