using System;


namespace FirstCsharp
{
    public class GetMaxMinSumAvg
    {

        public static int[] Get(int[] numbers)
        {
            int[] result = new int[4];
            //假設result[0]:Max result[1]:Min result[2]:Sum
            result[0] = numbers[0];
            result[1] = numbers[1];
            result[2] = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > result[0])
                {
                    result[0] = numbers[i];
                }
                if (numbers[i] < result[1])
                {
                    result[1] = numbers[i];
                }
                result[2] += numbers[i];
            }

            result[3] = result[2] / numbers.Length;
            return result;
        }

    }
}
