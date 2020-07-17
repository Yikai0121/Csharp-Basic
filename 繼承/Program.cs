using System;

namespace InheritanceLesson
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("123", "123", "123", "123");
            s.Eat(); //父類方法
            s.Study(); //子類方法

            //里氏替換原則
            //1.子類可以賦值給父類:如果有一個地方需要一個父類做參數，我們可以給一個子類替代

            Person p = new Student("A", "123", "123", "123");

            //2.如果父類中裝的是子類對象，那也可以講這個父類強轉為子類
            // //is用法: 表示類型轉換，如果轉換成功，返回一個true，否則返回false
            // if (p is Student)
            // {
            //     Student ss = (Student)p;
            //     ss.StudentTest();
            // }
            // else
            // {
            //     System.Console.WriteLine("轉換失敗");
            // }

            // //as用法: 表示轉換類型，如果轉換成功，返回一個對應類型，否則返回null
            
            // Student ss = p as Student;
            // ss.StudentTest();






        }
    }
}
