using System;


namespace FirstCsharp
{
    public class MethodOverload
    {

        public static int Test(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Test(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        public static string Test(string n1, string n2)
        {
            return n1 + n2;
        }


    }
}
