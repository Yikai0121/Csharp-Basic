using System;


namespace FirstCsharp
{
    public class Stringarray
    {
        //陣列有無返回值皆會改變傳進的參數
        public static void StringArray(string[] str)
        {
            for (int i = 0; i < str.Length/2; i++)
            {
                string temp = str[i];
                str[i] = str[str.Length-1-i];
                str[str.Length-1-i] = temp;
            }
        }
            ////有無傳回值方法皆正確
        // public static string [] StringArray(string[] str)
        // {
        //     for (int i = 0; i < str.Length/2; i++)
        //     {
        //         string temp = str[i];
        //         str[i] = str[str.Length-1-i];
        //         str[str.Length-1-i] = temp;
        //     }
        //     return str;
        // }

    }
}
