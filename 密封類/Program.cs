using System;

namespace 密封類
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public sealed class Person :Man //可繼承他類
    {

    }
    public class Man //: Person無法繼承
    {

    }
}
