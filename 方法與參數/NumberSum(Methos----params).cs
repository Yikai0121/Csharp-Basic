using System;


namespace FirstCsharp
{
    public class NumberSum
    {   //參數params:
        //將int [] n 變成 可變參數陣列，類型一致的元素都當作陣列的元素處理
        //params 可變參數必須是參數列表中最後一個元素，且具唯一性
        //public static int Test(string n,params int [] s)
        //public static int Test(string n,params int [] s,int id)---錯誤
        public static int Sum(params int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            return sum;
        }


    }
}
