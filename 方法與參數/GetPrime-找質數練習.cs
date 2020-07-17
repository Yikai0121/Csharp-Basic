using System;


namespace FirstCsharp
{
    public class GetPrime
    {
        public static bool Isprime(string s)
        {
            int number = Convert.ToInt32(s);
            if (number < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < number - 1; i++)
                {
                    if (number % i == 0)
                    {
                        //非質數判斷
                        return false;
                    }
                    // else
                    // {
                    //     //判斷錯誤 ex : 9%2!=0 return true 
                    //     return true;
                    // }
                }
                //若為質數傳回true
                return true;
            }
        }



    }
}
