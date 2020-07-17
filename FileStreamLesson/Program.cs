using System;
using System.IO;
using System.Text;


namespace FileStreamLesson
{
    class Program
    {
        static void Main(string[] args)
        {

            // //StreamWriter 讀取文件
            // using (StreamWriter sw = new StreamWriter(@"123.txt",true))//true 判斷追加不覆蓋
            // {
            //     sw.Write("加入這一行");
                
            // }
            // //StreamReader讀取文件
            // using (StreamReader sr = new StreamReader(@"123.txt"))
            // {
            //     while (!sr.EndOfStream) //沒有讀到最後循環
            //     {
            //         System.Console.WriteLine(sr.ReadLine());
            //     }

            // }




            // //使用Filestream讀取數據---操作字節(Byte)
            // FileStream fsread = new FileStream(@"123.txt",FileMode.OpenOrCreate,FileAccess.Read);
            // byte[] b = new byte[1024*1024*5];
            // //返回本次讀取的有效字節(byte)數
            // int r =fsread.Read(b,0,b.Length);
            // //將字節陣列中每一個元素按照指定編碼解碼成字串
            // string s = Encoding.Default.GetString(b,0,r);
            // fsread.Close();
            // //關閉
            // fsread.Dispose();
            // //釋放資源
            // System.Console.WriteLine(s);


            // //FileStream寫入數據
            // using (FileStream fwrite = new FileStream(@"123.txt",FileMode.OpenOrCreate,FileAccess.Write))
            // {
            //     string str = "這是一串新文字";
            //     byte [] b = Encoding.Default.GetBytes(str);
            //     fwrite.Write(b,0,b.Length);
            // }




        }
    }
}
