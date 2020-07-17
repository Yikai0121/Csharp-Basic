using System;


namespace FirstCsharp
{
    public class Doubleavg
    {
        public static double DoubleAvg(int[] n)
        {
            double sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            return sum / n.Length;
        }


    }


}

