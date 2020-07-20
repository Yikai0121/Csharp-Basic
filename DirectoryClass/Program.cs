using System;
using System.IO;

namespace DirectoryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory 文件夾 目錄
            //CreateDirectory:創建資料夾
            //Directory.CreateDirectory(@"C:\DirectoryClass\a");

            //Delete:刪除資料夾
            //Directory.Delete(@"C:\DirectoryClass\a");

            //Move:剪下
            //Directory.Move(@"C:\a",@"C:\DirectoryClass\new");


            //GetFiles:獲得指定文件下全部的文件路徑    ,"*.副檔名" 篩選需要的資料
            // string[] path = Directory.GetFiles(@"C:\Users\k2lairrol\Pictures\Pictures","*.jpg");
            // foreach (var item in path)
            // {
            //     System.Console.WriteLine(item);
            // }

            //GetDirectories:獲得指定目錄下所有文件夾的全路徑
            // string[] path =Directory.GetDirectories(@"C:\Users\k2lairrol\Pictures\Pictures");
            // foreach (var item in path)
            // {
            //     System.Console.WriteLine(item);
            // }

            // Exists:判斷指定文件是否存在
            // if (Directory.Exists(@"C:\DirectoryClass\new")) 
            // {
            //     for (int i = 0; i < 100; i++)
            //     {
            //         Directory.CreateDirectory(@"C:\DirectoryClass\new"+i);
            //     }
            // }
            

        }
    }
}
