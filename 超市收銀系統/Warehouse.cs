using System;
using System.Collections.Generic;

namespace 超市收銀系統
{
    public class Warehouse
    {

        List<List<ProductFather>> list = new List<List<ProductFather>>();

        public void ShowPros()
        {
            foreach (var item in list)
            {
                System.Console.WriteLine("我們超市有:" + item[0].Name + " 個數有:" + item.Count + "個," + "每個" + item[0].Price + "元");
            }
        }


        //存儲貨物 
        //將每個類想成貨架分門別類儲存
        public Warehouse()
        {
            list.Add(new List<ProductFather>());//list[0] 儲存Acer
            list.Add(new List<ProductFather>());//list[1] 儲存Samsung
            list.Add(new List<ProductFather>());//list[2] 儲存Wine
            list.Add(new List<ProductFather>());//list[3] 儲存Banana
        }
        //存貨
        public void Getpros(string strType, int count)
        {
            //商品進貨 很多類別 跟一堆數量 ex四種類別 一共100000個
            //用循環下去分配各個商品
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        list[0].Add(new Acer(Guid.NewGuid().ToString(), 10000, "宏碁筆電"));
                        break;
                    case "Samsung":
                        list[1].Add(new Samsung(Guid.NewGuid().ToString(), 20000, "三星手機"));
                        break;
                    case "Wine":
                        list[2].Add(new Wine(Guid.NewGuid().ToString(), 10, "酒"));
                        break;
                    case "Banana":
                        list[3].Add(new Banana(Guid.NewGuid().ToString(), 100, "香蕉"));
                        break;
                }
            }
        }

        //取貨
        public ProductFather[] Outpros(string strType, int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        pros[i] = list[0][0]; //list[0]====宏碁的貨架 list[0][0]貨架上的第一個貨物
                        list[0].RemoveAt(0); //拿完刪除第一個貨物 RemoveAt()刪除指定索引的一項
                        break;
                    case "Samsung":
                        pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "Wine":
                        pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Banana":
                        pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }
            return pros;
        }
    }



}
