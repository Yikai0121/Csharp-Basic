using System;

namespace Classbasic
{
    // 靜態類別中，可以有實例成員也可以有靜態成員
    // 再調用非靜態成員時候，需要使用對象名.實例成員 People A1 = new People();
    //                                        A1.M2()
    // 再調用靜態成員時候，需要使用類別名.靜態成員 People.M1()
    // 總結: 靜態成員必須使用類別去掉用，而非靜態成員使用對象名調用
    //      靜態函數中，只能訪問靜態成員，不允許訪問實例成員
    //      實例函數中，可以使用靜態成員，也可以使用實例成員
    //      靜態類中只允許靜態成員，不允許實例成員

    // 使用:
    // 1.如果你想要你的類當作一個"工具類"去使用，可以考慮將類別寫成靜態類別
    // 2.靜態類別在整個項目中資源共享(靜態儲存區域)
    //  只有在程序全部結束之後，才釋放資源
    public class People
    {
        private static string _name;

        public static string Name
        {
            get { return People._name; }
            set { People._name = value; }
        }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public static void M1()
        {
            Console.WriteLine("我是靜態方法");
        }
        public void M2()
        {
            System.Console.WriteLine("我是非靜態方法");
        }
    }
}
