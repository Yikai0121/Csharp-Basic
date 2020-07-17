using System;


namespace FirstCsharp
{
    class Program
    {

        static void Main(string[] args)
        {   

            // //GetPerimeterArea-計算圓面積與周長(Out參數)
            // double r =5;
            // double perimeter;
            // double area;
            // GetPerimeterArea.Getperarea(r,out perimeter,out area);
            // Console.WriteLine($"{r}{perimeter}{area}");
            
            // //Stringarray-字串陣列排序
            // string [] names = {"台北","台中","高雄","桃園","台南"};
            // Stringarray.StringArray(names);
            // for (int i = 0; i < names.Length; i++)
            // {
            //     System.Console.WriteLine(names[i]);
            // }
            
            // //GetPrime-判斷質數練習
            // System.Console.WriteLine("請輸入一個整數");
            // string strnumber = Console.ReadLine();
            // bool prime = GetPrime.Isprime(strnumber);
            // System.Console.WriteLine(prime);

            //Doubleavg-小數保留練習
            // int[] numbers = { 1, 5, 8, 6, 3, 2, 1 };
            // double avg = Doubleavg.DoubleAvg(numbers);
            // //保留兩位小數
            // string s = avg.ToString("0.00");
            // avg = Convert.ToDouble(s);
            // System.Console.WriteLine(avg);

            // //GetString-字串長度比較練習
            // string[] str = { "123456", "1132132132", "46465464646" };
            // string a = GetString.StringLong(str);
            // System.Console.WriteLine(a);

            //Practice-Method(ref)
            //提示用戶輸入兩個數字，計算這兩個數字之間所有整數的和
            //1.用戶只能輸入數字
            //2.計算兩個數字之間的和
            //3.要求第一個數字必須比第二個數字小，否就重新輸入
            // Console.WriteLine("請輸入第一個整數");
            // string strnumber1 = Console.ReadLine();
            // int number1 = PracticeMethod.Isnum(strnumber1);
            // Console.WriteLine("請輸入第二個整數");
            // string strnumber2 = Console.ReadLine();
            // int number2 = PracticeMethod.Isnum(strnumber2);
            // PracticeMethod.Vsnum(ref number1, ref number2);
            // int sum = PracticeMethod.Sum(number1, number2);
            // Console.WriteLine(sum);


            //BubbleSort:
            // PracticeBubbleSort.BubbleSort();

            //LeapYear:
            // bool year = LeapYear.LeapYearIs(2000);
            // Console.WriteLine(year);

            //GetSum:
            // int[] numbers = { 1, 8, 6, 5, 4, 2, 3, 9, 8, 5, 2, 2 };
            // int result = GetSum.Getsum(numbers);
            // Console.WriteLine(result);


            //GetMaxMinSumAvg:
            // int[] numbers = { 1, 23, 5, 5, 5, 5, 5, 5, 5, 5, 10000 };
            // int[] result = GetMaxMinSumAvg.Get(numbers);
            // Console.WriteLine($"MAX:{result[0]},Mix:{result[1]},Sum:{result[2]},AVG:{result[3]}");



            //CheckUser-----Out:
            // Console.WriteLine("請輸入帳號");
            // string username = Console.ReadLine();
            // Console.WriteLine("請輸入密碼");
            // string pwd = Console.ReadLine();
            // string msg;
            // bool result =    .Checkuser(username, pwd, out msg);
            // Console.WriteLine($"登入結果:{result},登入訊息:{msg}");

            //TranslateNumbers-----ref
            // int n1 = 10;
            // int n2 = 20;
            // Translate.TranslateNum(ref n1, ref n2);
            // Console.WriteLine(n1);
            // Console.WriteLine(n2);

            //NumberSum------params
            // int result = NumberSum.Sum(22, 55, 33, 44, 55, 55, 5, 5);
            // Console.WriteLine(result);

        }



    }
}
