using System;


namespace FirstCsharp
{
    public class Translate
    {   //ref 參數:能將一個變量帶入一個方法中進行改變，改變完成後在將改變後的值帶出
        //ref參數要求在方法外必須為其賦值，而方法內部可以賦值
        public static void TranslateNum(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;

        }

    }


}

