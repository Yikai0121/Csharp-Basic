using System;
using System.Diagnostics;
using System.IO;

namespace 抽想類別簡單工廠設計練習
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("請輸入要去的硬碟");
            string path = Console.ReadLine();
            System.Console.WriteLine("請輸入要開啟的文件名稱");
            string filename = Console.ReadLine();

            FileFather ff = GetFile(filename, path + filename);
            ff.Openfile();


        }

        public static FileFather GetFile(string filename, string fullPath)
        {
            string extension = Path.GetExtension(filename);
            FileFather ff = null;
            switch (extension)
            {
                case ".txt":
                    ff = new TxtPath(fullPath);
                    break;
                case ".jpg":
                    ff = new JpgPath(fullPath);
                    break;
            }
            return ff;
        }
    }


    public abstract class FileFather
    {
        public string fullPath { get; set; }
        public FileFather(string fullPath)
        {
            this.fullPath = fullPath;
        }
        public abstract void Openfile();

    }
    public class TxtPath : FileFather
    {
        public TxtPath(string fullPath) : base(fullPath)
        {

        }
        public override void Openfile()
        {
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo(this.fullPath) { UseShellExecute = true };
            p.StartInfo = psi;
            p.Start();

        }
    }
    public class JpgPath : FileFather
    {

        public JpgPath(string fullPath) : base(fullPath)
        {

        }
        public override void Openfile()
        {
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo(this.fullPath) { UseShellExecute = true };
            p.StartInfo = psi;
            p.Start();

        }
    }

}
