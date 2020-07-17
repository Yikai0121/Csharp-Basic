using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCsharp
{
    //提示用戶輸入兩個數字，計算這兩個數字之間所有整數的和
    //1.用戶只能輸入數字
    //2.計算兩個數字之間的和
    //3.要求第一個數字必須比第二個數字小，否就重新輸入
    public class PracticeMethod
    {
        public static int Isnum(string str)
        {
            while (true)
            {
                try
                {
                    int num = Convert.ToInt32(str);
                    return num;
                }
                catch
                {

                    System.Console.WriteLine("錯誤!請輸入整數");
                    str = Console.ReadLine();
                }
            }

        }
        //內部接收新的s1,s2不會改變到方法外的變數，需用ref
        //ref:能將變量帶入方法中進行改變，改變完成後在將改變後的值帶出
        public static void Vsnum(ref int n1,ref int n2)
        {
            while (true)
            {
                if (n1 < n2)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("錯誤!第一個數字必須比第二個數字小,請輸入第一個整數");
                    string s1 = Console.ReadLine();
                    n1 = Isnum(s1);
                    Console.WriteLine("請輸入第二個整數");
                    string s2 = Console.ReadLine();
                    n2 = Isnum(s2);
                }
            }

        }
        public static int Sum(int n1, int n2)
        {
            int sum = 0;
            for (int i = n1; i <= n2; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}


