﻿using System;
using System.Diagnostics;

namespace ProcessLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // //獲得當前程序中所有正在運行進程
            // Process[] pros = Process.GetProcesses();
            // foreach (var item in pros)
            // {
            //     System.Console.WriteLine(item);
            // }

            //通過進程打開應用程式
            // Process.Start("notepad");

            // 通過一個進程打開指定文件
            // Process p = new Process();
            // p.StartInfo = new ProcessStartInfo(@"C:\Users\k2lairrol\Documents\GitHub\Csharp-Basic\ProcessLesson\123.txt") { UseShellExecute = true };
            // p.Start();

            Process.Start(new ProcessStartInfo(@"C:\Users\k2lairrol\Documents\GitHub\Csharp-Basic\ProcessLesson\123.txt")
            {
                UseShellExecute = true
            });


        }
    }
}
