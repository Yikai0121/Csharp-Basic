using System;
using System.Diagnostics;
using System.IO;

namespace 抽想類別簡單工廠設計練習2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("請輸入要去的硬碟");
            string path = Console.ReadLine();
            System.Console.WriteLine("請輸入要開啟的文件名稱");
            string filename = Console.ReadLine();
            
            FileFather ff = GetFileName(filename,path+filename);
            ff.Openfile();


        }

        public static FileFather GetFileName(string filename, string fullPath)
        {
            string extention = Path.GetExtension(filename);
            FileFather ff = null;
            switch (extention)
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
        public string fullpath { get; set; }
        public FileFather(string fullpath)
        {
            this.fullpath = fullpath;
        }
        public abstract void Openfile();
    }

    public class TxtPath : FileFather
    {
        public TxtPath(string fullpath) : base(fullpath)
        {

        }
        public override void Openfile()
        {
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo(this.fullpath) { UseShellExecute = true };
            p.StartInfo = psi;
            p.Start();
        }
    }
    public class JpgPath : FileFather
    {
        public JpgPath(string fullpath) : base(fullpath)
        {

        }
        public override void Openfile()
        {
           Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo(this.fullpath) { UseShellExecute = true };
            p.StartInfo = psi;
            p.Start();
        }
    }
}
