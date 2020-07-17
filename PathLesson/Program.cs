using System;
using System.IO;

namespace PathLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"C:\Users\k2lairrol\Downloads\FirstCsharp\PathLesson\Test.txt";
            System.Console.WriteLine(Path.GetFileName(str)); //Test.txt
            System.Console.WriteLine(Path.GetFileNameWithoutExtension(str)); //Test
            System.Console.WriteLine(Path.GetExtension(str)); //.txt
            System.Console.WriteLine(Path.GetDirectoryName(str)); //所在文件夾名稱
            System.Console.WriteLine(Path.GetFullPath(str));//全部路徑
            System.Console.WriteLine(Path.Combine(@"c:\a\","b.txt")); //結合字串作為路徑
            
            
            // int lastindex = str.LastIndexOf('\\');   
            // System.Console.WriteLine(str.Substring(lastindex+1));
        }
    }
}
