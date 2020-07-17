using System;
using System.IO;
using System.Text;

namespace FileLesson
{
    class Program
    {
        static void Main(string[] args)
        {   
            //寫入 並覆蓋
            // File.WriteAllLines(@"new.txt",new string[]{"adsadad","sfdsfafds"});
            // File.WriteAllText(@"new.txt","skfalkjfkljslkdf");
            //寫入 後面加入字串
            // File.AppendAllText(@"new.txt","前面還在嗎");




            // //讀取 轉為陣列 簡單操作文件
            // string [] content = File.ReadAllLines(@"C:\Users\k2lairrol\Downloads\FirstCsharp\FileLesson\new.txt",Encoding.Default);
            // foreach (var item in content)
            // {
            //     System.Console.WriteLine(item);
            // }
            // //讀取 最簡單讀取方法
            // string  content2 = File.ReadAllText(@"C:\Users\k2lairrol\Downloads\FirstCsharp\FileLesson\new.txt",Encoding.Default);
            // System.Console.WriteLine(content2);



            // //寫入 將字串轉為byte 再藉由encoding轉換再寫入
            // string s = "因實體還沒創建，所以 a 跟 $el 都是 undefined";
            // byte [] s1 = Encoding.Default.GetBytes(s);
            // //沒有這個文件，將會創建一個，有的話覆蓋
            // File.WriteAllBytes(@"C:\Users\k2lairrol\Downloads\FirstCsharp\FileLesson\new.txt",s1);
            
            // //讀取 將文件轉換為byte 在解碼為字串 輸出
            //將字組中每一個元素都按照我們的編碼格式解碼成字串
            //  byte[] b = File.ReadAllBytes(@"C:\Users\k2lairrol\Downloads\FirstCsharp\FileLesson\Test.txt");
            //將字組中每一個元素都按照我們的編碼格式解碼成字串:UTF-8 ASCII Unicode
            // string s = Encoding.Default.GetString(b);
            // System.Console.WriteLine(s);


            // bool f =File.Exists(@"C:\Users\k2lairrol\Downloads\FirstCsharp\FileLesson\Test.txt");//判斷文件是否存在

            //File.Create(@"C:\Users\k2lairrol\Downloads\FirstCsharp\FileLesson\Test.txt"); //創建文件
            //File.Delete(@"C:\Users\k2lairrol\Downloads\FirstCsharp\FileLesson\Test.txt");//刪除文件
            // File.Copy(@"C:\Users\k2lairrol\Downloads\FirstCsharp\FileLesson\Test.txt",@"C:\Users\k2lairrol\Downloads\FirstCsharp\FileLesson\newTest.txt",true);
            //文件複製(source,target,true) true表示文件存在時覆蓋，文件存在時沒加true會錯誤

            // File.Move(@"C:\Users\k2lairrol\Downloads\FirstCsharp\FileLesson\newTest.txt",@"C:\Users\k2lairrol\Downloads\FirstCsharp\FileLesson\verynewTest.txt");
            //重新命名

        }
    }
}
