using System;


namespace FirstCsharp
{
    public class Getnumbers
    {

        public static int Get(string s)
        {

            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("請輸入整數");
                    s = Console.ReadLine();

                }
            }

        }


    }
}
