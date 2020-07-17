using System;
using System.Collections.Generic;


namespace 超市收銀系統
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMarket sm = new SuperMarket();
            //展示商品
            sm.ShowPush();
            //跟用戶交流
            sm.AskBuying();
        }
    }



}
