using System;

namespace 簡單工廠設計
{
    class Program
    {
        //克
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入你要的品牌");
            string Brand = Console.ReadLine();
            NoteBook nb = GetBrandclass.GetBrand(Brand);
            nb.GetNotebook();
        }
        
    }
public class GetBrandclass{
    public static NoteBook GetBrand(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "Acer":
                    nb = new Acer();
                    break;
                case "Asus":
                    nb = new Asus();
                    break;
                case "HP":
                    nb = new HP();
                    break;
                case "Apple":
                    nb = new Apple();
                    break;
            }
            return nb;
        }
}
    public abstract class NoteBook
    {
        public abstract void GetNotebook();
    }
    public class Acer : NoteBook
    {
        public override void GetNotebook()
        {
            System.Console.WriteLine("Acer");
        }
    }
    public class Asus : NoteBook
    {
        public override void GetNotebook()
        {
            System.Console.WriteLine("Asus");
        }
    }
    public class HP : NoteBook
    {
        public override void GetNotebook()
        {
            System.Console.WriteLine("HP");
        }
    }
    public class Apple : NoteBook
    {
        public override void GetNotebook()
        {
            System.Console.WriteLine("Apple");
        }
    }

}
