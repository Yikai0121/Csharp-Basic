using System;

namespace 多態
{
    class Program
    {
        static void Main(string[] args)
        {
            //讓一個對象能夠表現出多種的狀態(類型)
            //實現多態三種方法
            //1.虛方法 2.抽象類 3.介面
            Person[] p = new Person[8];
            Taiwanese t1 = new Taiwanese("小花");
            Taiwanese t2 = new Taiwanese("小華");
            Japanese j1 = new Japanese("山下智久");
            Japanese j2 = new Japanese("山上智久");
            Korean k1 = new Korean("太研");
            Korean k2 = new Korean("潤兒");
            American a1 = new American("Kobe");
            American a2 = new American("Amy");
            Person[] ps = { t1, t2, j1, j2, k1, k2, a1, a2 };








            for (int i = 0; i < ps.Length; i++)
            {
                ps[i].SayHello();






                // if (ps[i] is Taiwanese)
                // {
                //     ((Taiwanese)ps[i]).SayHello();
                // }
                // else if (ps[i] is Korean)
                // {
                //     ((Korean)ps[i]).SayHello();
                // }
                // else if (ps[i] is American)
                // {
                //     ((American)ps[i]).SayHello();
                // }
                // else
                // {
                //     ((Japanese)ps[i]).SayHello();
                // }

            }
        }
    }
   

    public class Person
    {

        private string _name;
        public string Name
        {

            get { return _name; }
            set { _name = value; }
        }
        public Person(string name)
        {
            this.Name = name;
        }
        public virtual void SayHello()
        {
            System.Console.WriteLine("我是人類");
        }


    }
    public class Taiwanese : Person
    {
        public Taiwanese(string name)
            : base(name)
        {

        }
        public override void SayHello()
        {
            System.Console.WriteLine("我是台灣人 我叫{0}", this.Name);
        }
    }
    public class Japanese : Person
    {
        public Japanese(string name)
            : base(name)
        {

        }
        public override void SayHello()
        {
            System.Console.WriteLine("我是Japanese,我叫{0}", this.Name);
        }
    }
    public class Korean : Person
    {
        public Korean(string name)
            : base(name)
        {

        }
        public override void SayHello()
        {
            System.Console.WriteLine("我是Korean,我叫{0}", this.Name);
        }
    }
    public class American : Person
    {
        public American(string name)
            : base(name)
        {

        }
        public override void SayHello()
        {
            System.Console.WriteLine("我是American,我叫{0}", this.Name);
        }
    }
}
