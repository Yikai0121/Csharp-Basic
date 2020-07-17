using System;

namespace SpiltPractice
{
    class Program
    {
        static void Main(string[] args)
        {

           
           
            // //string.join 在陣列中插入所需字串
            // string [] names = {"First","Second","Third"};
            // string str = string.Join("|",names);
            // System.Console.WriteLine(str);




            // //string.IsNullOrEmpty() 判斷String 是否為空會null
            // string str = "";
            // if (string.IsNullOrEmpty(str))
            // {
            //     System.Console.WriteLine("Y");
            // }
            // else
            // {
            //     System.Console.WriteLine("N");
            // }


            //Trim() 去掉空格
            // string str = "          hhh    h            ";
            // str = str.Trim(); //去掉全部空格
            // string strstary = str.TrimStart();//去掉前面空格
            // string strend = str.TrimEnd();//去掉後面空格
            // System.Console.WriteLine(str);
            // System.Console.WriteLine(strstary);
            // System.Console.WriteLine(strend);



            // //Lastindexod  Substring應用
            // //先尋找最後一個\位置
            // //再由Substring去擷取字串
            // string path = @"c:\f\f\d\sa\sa\df\f\ds\sf\ds\f\sd\機密文件.pdf";
            // int index = path.LastIndexOf("\\"); //代表一個\
            // path = path.Substring(index+1); //包含本身，所以+1只取所需字串
            // System.Console.WriteLine(index);
            // System.Console.WriteLine(path);


            // //Lastindexof找尋字最後出現的位置
            // //indexof = 找尋字第一個出現的位置
            // string str = "今天有夠忙的拉";
            // int index = str.IndexOf('天',1);
            // Console.WriteLine(index);




            // //Start/end with 字串開始或結束
            // string str = "今天有夠忙的拉";
            // if(str.StartsWith("今天")){
            //     System.Console.WriteLine("Y");
            // }
            // else{
            //     System.Console.WriteLine("N");
            // }


            //Substring 擷取字串 [1]~[2]的字
            // string str = "今天有夠忙的拉";
            // str = str.Substring(6);
            // System.Console.WriteLine(str);



            // //contains 與 replace 用法
            // string str = "今天很快樂";
            // if (str.Contains("快樂"))
            // {
            //     str = str.Replace("快樂", "超級快樂");
            // }
            // Console.WriteLine(str);

            // //練習 日期2008-08-08中分析出2008年08月08日
            // //讓用戶輸入上述日期格式便將其轉換
            // string ss = "2008-08-08";
            // string [] date = ss.Split(new char []{'-'},StringSplitOptions.RemoveEmptyEntries);
            // System.Console.WriteLine("{0}年{1}月{2}號",date[0],date[1],date[2]);



            // string s = "a b df_ + - ,,,";
            // char[] chs = { ' ', '_', '-', '+', ',' };
            // string[] str = s.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            // foreach (var item in str)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}
