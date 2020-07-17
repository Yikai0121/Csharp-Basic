using System;

namespace InheritancePractice
{
    class Program
    {
        //         里氏替換原則

        // 1.子類可以賦值給父類:如果有一個地方需要一個父類做參數，我們可以給一個子類替代

        // 2.如果父類中裝的是子類對象，那也可以講這個父類強轉為子類

        // 3.is:表示類型轉換，如果轉換成功，返回一個true，否則返回false
        //   as:表示轉換類型，如果轉換成功，返回一個對應類型，否則返回null
        static void Main(string[] args)
        {
            Person[] per = new Person[10];
            Random r = new Random();
            for (int i = 0; i < per.Length; i++)
            {
                int rnumber = r.Next(1, 7);
                switch (rnumber) //隨機賦值
                {
                    case 1:
                        per[i] = new Student();
                        break;
                    case 2:
                        per[i] = new Teacher();
                        break;
                    case 3:
                        per[i] = new Driver();
                        break;
                    case 4:
                        per[i] = new Monster();
                        break;
                    case 5:
                        per[i] = new Handsome();
                        break;
                    case 6:
                        per[i] = new Person();
                        break;
                }

            }

            for (int i = 0; i < per.Length; i++)
            {
                if (per[i] is Student)
                {
                    ((Student)per[i]).StudentSayHI();

                }
                else if (per[i] is Teacher)
                {
                    ((Teacher)per[i]).TeacherSayHI();

                }
                else if (per[i] is Driver)
                {
                    ((Driver)per[i]).DriverSayHI();

                }
                else if (per[i] is Monster)
                {
                    ((Monster)per[i]).MonsterSayHI();

                }
                else if (per[i] is Handsome)
                {
                    ((Handsome)per[i]).HandsomeSayHI();

                }
                else
                {
                    per[i].PersonSayHI();
                }
            }


        }



        public class Person
        {
            public void PersonSayHI()
            {
                System.Console.WriteLine("我是人類");
            }
        }
        public class Student : Person
        {
            public void StudentSayHI()
            {
                System.Console.WriteLine("我是學生");
            }
        }
        public class Teacher : Person
        {
            public void TeacherSayHI()
            {
                System.Console.WriteLine("我是老師");
            }
        }
        public class Driver : Person
        {
            public void DriverSayHI()
            {
                System.Console.WriteLine("我是司機");
            }
        }
        public class Monster : Person
        {
            public void MonsterSayHI()
            {
                System.Console.WriteLine("我是怪獸");
            }
        }
        public class Handsome : Person
        {
            public void HandsomeSayHI()
            {
                System.Console.WriteLine("我是帥哥");
            }
        }
    }
}
