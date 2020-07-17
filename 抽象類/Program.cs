using System;

namespace 抽象類
{
    class Program
    {
        static void Main(string[] args)
        {
            // //使用多態求矩形面積及圓形面積周長
            // Shape circle = new Square(5, 10);//new Circle(5);
            // double area = circle.GetArea();
            // double perimeter = circle.GetPerimeter();
            // System.Console.WriteLine("面積{0}，周長{1}",area,perimeter);


            //用多態 來實現將隨身硬碟 USB Mp3... 插到電腦上讀取數據
            MobileStorage ms = new Mp3();
            Computer cpu = new Computer(ms); //應用構造函數
            //cpu.Ms = ms; //ms 賦值給computer裡面的Ms //沒有構造函數
            ms.Read();
            ms.Write();




            //Computer cpu = new Computer();
            // cpu.CpuRead(ms);
            // cpu.CpuWrite(ms);




        }
    }

    public abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }
    public class MobileDisk : MobileStorage
    {
        public override void Read()
        {
            System.Console.WriteLine("移動硬碟再讀取數據");
        }

        public override void Write()
        {
            System.Console.WriteLine("移動硬碟在寫入數據");
        }
    }
    public class UDisk : MobileStorage
    {
        public override void Read()
        {
            System.Console.WriteLine("USB在讀取數據");
        }

        public override void Write()
        {
            System.Console.WriteLine("USB在寫入數據");
        }
    }
    public class Mp3 : MobileStorage
    {
        public override void Read()
        {
            System.Console.WriteLine("Mp3在寫入數據");
        }

        public override void Write()
        {
            System.Console.WriteLine("Mp3在寫入數據");
        }
        public void PlayMusic()
        {
            System.Console.WriteLine("播音樂");
        }


    }
    public class Computer
    {
        private MobileStorage _ms;

        public MobileStorage Ms { get => _ms; set => _ms = value; }

        public Computer(MobileStorage m)
        {
            this.Ms = m;
        }

        public void CpuRead()
        {
            Ms.Read();
        }
        public void CpuWrite()
        {
            Ms.Write();
        }

    }

















    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
    public class Circle : Shape
    {
        private double _r;
        public double R
        {
            get { return _r; }
            set { _r = value; }
        }
        public Circle(double r)
        {
            this.R = r;
        }
        public override double GetArea()
        {
            return Math.PI * this.R * this.R;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * this.R;
        }
    }
    public class Square : Shape
    {
        private double _height;
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        private double _width;
        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public Square(double height, double weight)
        {
            this.Height = height;
            this.Width = weight;
        }

        public override double GetArea()
        {
            return this.Height * this.Width;
        }

        public override double GetPerimeter()
        {
            return 2 * (this.Height + this.Width);
        }
    }

    public abstract class Animal
    {
        public abstract void Bark(); //不能有方法體
        // public void Test()
        // {
        //     //空實現
        // }
        public abstract string Name
        {
            get; set;
        }
    }
    public class Dog : Animal
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Bark()
        {
            System.Console.WriteLine("狗狗旺旺叫");
        }

    }
    public class Cat : Animal
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Bark()
        {
            System.Console.WriteLine("貓咪喵喵叫");
        }
    }
}
