using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //顯示實現interface是為了解決方法的重名問題


            IFlyable fly = new Bird();
            fly.Fly();
            Bird bird = new Bird();
            bird.Fly();
            IDunk d = new Person();
            d.Dunk();
            Person p = new Person();
            p.Dunk();
        }
    }


    public class Bird : IFlyable
    {
        public void Fly()
        {
            System.Console.WriteLine("鳥會飛");
        }
        void IFlyable.Fly() //顯示interface方法
        {
            System.Console.WriteLine("interface的飛");
        }
    }
    public interface IFlyable
    {
        void Fly();
    }

    public class Person : IDunk
    {
        public void Dunk()
        {
            System.Console.WriteLine("我會灌籃");
        }
        void IDunk.Dunk() //顯示實現interface
        {
            System.Console.WriteLine("interface的灌籃");
        }
        public void SayHello()
        {
            System.Console.WriteLine("Hi 我是人類");
        }
    }

    public class Student : Person, IDunk
    {
        public new void Dunk()
        {
            System.Console.WriteLine("我可以灌籃");
        }
    }

    public interface IDunk
    {
        void Dunk();
    }

}
