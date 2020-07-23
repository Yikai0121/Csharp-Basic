using System;

namespace 委託概念
{
    //聲明委託指向一個函數
    public delegate void DelSayhi(string name);

    class Program
    {
        static void Main(string[] args)
        {
            // DelSayhi del = SayHiTaiwanese;
            // del("ABC");

            // Test("台灣",SayHiTaiwanese);
            // Test("Yo", delegate (string name)
            // {
            //     System.Console.WriteLine("吃飯沒" + name);
            // });
            // DelSayhi del = delegate (string name)
            // {
            //     System.Console.WriteLine("你好" + name);
            // };
            // del("Alex");

            DelSayhi del = (string name) => { System.Console.WriteLine("你好" + name); };
            del("Amy");


        }
        // public static void Test(string name, DelSayhi del)
        // {
        //     //調用
        //     del(name);
        // }
        // public static void SayHiTaiwanese(string name)
        // {
        //     System.Console.WriteLine("吃飯沒" + name);
        // }
        // public static void SayHiEnglish(string name)
        // {
        //     System.Console.WriteLine("Hello" + name);
        // }
    }
}
