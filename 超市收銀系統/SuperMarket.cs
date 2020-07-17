using System;
namespace 超市收銀系統
{
    public class SuperMarket
    {
        Warehouse wh = new Warehouse();

        //創建超市對象時從倉庫導入貨物
        public SuperMarket()
        {
            wh.Getpros("Acer", 1000);
            wh.Getpros("Samsung", 1000);
            wh.Getpros("Wine", 1000);
            wh.Getpros("Banana", 1000);
        }

        public void AskBuying()
        {
            System.Console.WriteLine("歡迎光臨，請問你需要什麼?");
            System.Console.WriteLine("我們有Acer,Samsung,Wine,Banana");
            string strType = Console.ReadLine();
            Console.WriteLine("你需要多少?");
            int count = Convert.ToInt32(Console.ReadLine());

            //去倉庫取貨
            ProductFather[] pros = wh.Outpros(strType, count);
            //計算價格
            double Money = GetMoney(pros);
            System.Console.WriteLine("你的商品價格為:{0}", Money);
            System.Console.WriteLine("請選擇您的打折方式: 1--不打折 2--打九折 3--打八五折 4--買300送50 5--買500送100");
            string input = Console.ReadLine();
            CalFather cal = GetFinalMoney(input);
            double totalMoney = cal.GetTotalMoney(Money);
            System.Console.WriteLine("打完折後，您應付{0}元", totalMoney);
            System.Console.WriteLine("以下為你購買清單");
            foreach (var item in pros)
            {
                System.Console.WriteLine("商品名稱:" + item.Name + "   商品單價:" + item.Price + "   商品編號:" + item.ID);

            }
            System.Console.WriteLine("數量:" + pros.Length);


        }


        public void BuyItem()
        {

        }
        //根據用戶的貨物計算價錢
        public double GetMoney(ProductFather[] pros)
        {
            double Money = 0;

            for (int i = 0; i < pros.Length; i++)
            {
                Money += pros[i].Price;
            }
            return Money;
        }
        CalFather GetFinalMoney(string input)
        {
            CalFather cal = null;
            switch (input)
            {
                case "1":
                    cal = new CalNormal();
                    break;
                case "2":
                    cal = new CalRate(0.9);
                    break;
                case "3":
                    cal = new CalRate(0.85);
                    break;
                case "4":
                    cal = new CalMN(300, 50);
                    break;
                case "5":
                    cal = new CalMN(500, 100);
                    break;

            }
            return cal;
        }
        public void ShowPush()
        {
            wh.ShowPros();
        }
    }



}
