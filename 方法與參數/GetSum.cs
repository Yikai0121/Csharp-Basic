using System;


namespace FirstCsharp
{
    public class GetSum
    {
        
       public static int Getsum(int [] numbers){

           int sum = 0;
           for (int i = 0; i < numbers.Length; i++)
           {
               sum += numbers[i];
           }
            return sum;
       }


    }
}
