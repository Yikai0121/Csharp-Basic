using System;
namespace InheritanceLesson
{
    public class Student : Person
    {
        private string _number;
        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }
        //base() 繼承父類構造函數
        public Student(string name, string id, string gender, string number)
                : base(name, id, gender)
        {
            this.Number = name;

        }


        public void Study()
        {
            System.Console.WriteLine("I can Study");
        }

        //隱藏從父類繼承過來的同名成員
        //隱藏的後果子類調用不到父類成員
        public new void Drink()
        {
            System.Console.WriteLine("Eat");
        }
        public void StudentTest()
        {
            System.Console.WriteLine("轉換成功");
        }
    }
}
