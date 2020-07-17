using System;

namespace 類的補充
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
     //多人開發一專案可能會每個人都寫一個類，關鍵字partial
    //使在命名空間下的類視為同一類
    //且類中欄位屬性方法可以共用
    //但不能有重複
    public partial class Person
    {
        private string _name;
    }
    public partial class Person
    {   //private string _name;錯誤
        public void Test()
        {
            
            // _name = "123";
        }
    }
}
