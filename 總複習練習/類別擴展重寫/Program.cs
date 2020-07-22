using System;

namespace 類別擴展重寫
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p =new Person();
            p.SayHello();
            Employee e = new Employee();
            e.SayHello();
        }
    }
    public class Person
    {
        public string Name { get; set;}
        public char Gender { get; set; }
        public int age { get; set; }
        public virtual void SayHello()
        {
            System.Console.WriteLine("Hi,I am Person");
        }

    }
    public class Employee : Person
    {
        public string Salary { get; set; }
        public override void SayHello()
        {
            System.Console.WriteLine("HI I am Employee");
        }
    }

}
