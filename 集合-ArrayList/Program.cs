using System;
using System.Collections;

namespace ArrayListLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            //將隨機1-10加入集合，但隨機數字不可重複
            Random r = new Random();
            //不使用i<list.count 因為未賦值前list個數為0
            for (int i = 0; i < 10; i++)
            {
                int rnumber = r.Next(0, 10);
                
                    if (!list.Contains(rnumber))
                    {
                        list.Add(rnumber);
                    }
                

                else //如有重複值 ex 第五次執行重複 不執行i--會少一個個數
                {
                    i--;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                System.Console.WriteLine(list[i]);
            }





            // //求集合總和與MAX
            // list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            // int sum = 0;
            // int max = (int)list[0];
            // for (int i = 0; i < list.Count; i++)
            // {
            //     if ((int)list[i] > max)
            //     {
            //         max = (int)list[i];
            //     }
            //     sum += (int)list[i];
            // }
            // System.Console.WriteLine(sum);
            // System.Console.WriteLine(max);





            // //添加單個元素
            // list.Add("你好");
            // list.Add(1111);
            // list.Add("你好");
            // list.Add(1111);
            // list.Add("你好");
            // list.Add(1111);

            // //添加集合元素
            // // list.AddRange(new int[] { 1, 5, 6, 8, 6, 2, 1, 10 });
            // // list.AddRange(list);
            // System.Console.WriteLine(list.Count); //元素個數
            // System.Console.WriteLine(list.Capacity); //可包含的元素個數

            //list.Clear(); //清空元素
            // list.Remove(1111);//清除單元素
            // list.RemoveAt(0);//根據位置刪除元素
            // list.RemoveRange(0,3);//根據範圍刪除元素
            // list.Sort();//升序排列
            // list.Reverse();//反轉
            // list.Insert(1, "插入的"); //在指定位置插入一個元素
            // list.InsertRange(0, new int[] { 1, 5, 5, 5, 5, 1 });//在指定位置插入集合
            // bool b =list.Contains("你好");//判斷是否包含指定元素
            // list.Add("我在裡面嗎");
            // if (!list.Contains("我在裡面嗎"))
            // {
            //     list.Add("我在裡面嗎");
            // }
            // else
            // {
            //     System.Console.WriteLine("已經有了");
            // }
            // for (int i = 0; i < list.Count; i++)
            // {
            //     System.Console.WriteLine(list[i]);
            // }

        }
    }
}
