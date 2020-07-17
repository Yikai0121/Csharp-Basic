using System;


namespace FirstCsharp
{
    public class GetString
    {
        public static string StringLong(string[] n)
        {
            string max = n[0];
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i].Length > max.Length)
                {
                    max = n[i];
                }
            }
            return max;

        }



    }
}
