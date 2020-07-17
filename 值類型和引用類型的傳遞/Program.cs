using System;

namespace 值類型和引用類型的傳遞
{
    class Program
    {
        static void Main(string[] args)
        {   
            //值類型傳遞
            int n1 = 10;
            int n2 = n1;
            n2 = 20;
            System.Console.WriteLine(n1); //10
            System.Console.WriteLine(n2); //20

            //引用類型傳遞
            Person p = new Person();
            p.Name = "A";
            Person p2 = p;
            p2.Name ="B";
            System.Console.WriteLine(p.Name);
            System.Console.WriteLine(p2.Name);

            //string 是引用類型，但string的不可變性，創建新的string就會開闢新空間
            string str1 = "ABC";
            string str2 = str1;
            str2 = "CBA";
            System.Console.WriteLine(str1);
            System.Console.WriteLine(str2);

            
        }
        public class Person{
            private string name;

            public string Name { get => name; set => name = value; }
        }
    }
}
