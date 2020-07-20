using System;
using System.Diagnostics;
using System.IO;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] path = Directory.GetFiles(@"C:\Users\k2lairrol\Pictures\Pictures");
            // System.Console.WriteLine(path.Length);

            Process p = new Process();
            p.StartInfo.FileName = @"C:\Users\user\Desktop\1.txt";
            p.Start();


            // //把{"諸葛亮","鳥叔","卡卡西","卡哇伊"}變成 諸葛亮|鳥叔|卡卡西|卡哇伊，再把|切割掉
            // string[] str1 = { "諸葛亮", "鳥叔", "卡卡西", "卡哇伊" };
            // string strnew1 = string.Join('|', str1);
            // foreach (var item in strnew1)
            // {
            //     System.Console.WriteLine(item);
            // }

            // //用戶輸入一句話，判斷這句話有無邪惡，如果有邪惡替換成**，ex:老牛很邪惡---老牛很**

            // string str2 = "老牛很邪惡";
            // if (str2.Contains("邪惡"))
            // {
            //     str2 = str2.Replace("邪惡", "**");
            // }
            // System.Console.WriteLine(str2);


            // //找出字串中'e'的位置有哪些
            // string stre = "adadesesesdfefesdfesfesdesef";
            // int index = stre.IndexOf('e');
            // System.Console.WriteLine(index);
            // int count = 1;
            // while (index != -1)
            // {
            //     count++;
            //     index = stre.IndexOf('e', index + 1);
            //     if (index == -1)
            //     {
            //         return;
            //     }
            //     System.Console.WriteLine("第{0}次出現e的位置{1}", count, index);

            // }



            //Email中提取用戶名和域名 k2lairrol@gmail.com
            // string email = "k2lairrol@gmail.com";

            // string name = email.Substring(0, email.IndexOf('@', 1));
            // System.Console.WriteLine(email);
            // string email2 = email.Substring(email.LastIndexOf('@')+1);

            // System.Console.WriteLine(email2);


            //將 hello c sharp 轉換成 sharp c hello

            // string str = "hello c sharp";
            // string [] newstr= str.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
            // for (int i = 0; i < newstr.Length/2; i++)
            // {
            //     string temp = newstr[0];
            //     newstr[0] = newstr[newstr.Length-1];
            //     newstr[newstr.Length-1] = temp;
            // }
            // str = string.Join(" ",newstr);
            // foreach (var item in newstr)
            // {
            //     System.Console.WriteLine(item);
            // }


            // //對數列進行反轉，升降冪排列
            // int[] nums = { 1, 5, 9, 7, 8, 6, 4, 2, 3, 11, 55, 88, 66, 44, 22 };

            // for (int i = 0; i < nums.Length / 2; i++)
            // {
            //     int temp = nums[i];  //temp = 1
            //     nums[i] = nums[nums.Length - 1 - i]; // 
            //     nums[nums.Length - 1 - i] = temp;

            // }
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     System.Console.WriteLine(nums[i]);
            // }
            /*
            int [] nums ={1,2,3,4,5,6,7,8,9} 
            example:                                    9 ----- nums.length
            1st:8 7 6 5 4 3 2 1 9 交換8次 i = 0  j = 8   j = nums.length-1-0      (j = nums.length-1-i)
            2nd:7 6 5 4 3 2 1 8 9 交換7次 i = 1  j = 7   j = nums.length-1-1      (j = nums.length-1-i)
            3rd:6 5 4 3 2 1 7 8 9 交換6次 i = 2  j = 6   j = nums.length-1-2      (j = nums.length-1-i)
            8次    
        **/

            // int[] numbers = { 1, 5, 8, 4, 6, 3, 2, 5, 9, 10 };
            // for (int i = 0; i < numbers.Length - 1; i++) //第i次循環 總共循環numbers.length-1次
            // {
            //     for (int j = 0; j < numbers.Length - 1; j++) //開始交換 交換次數為 numbers.Length - 1 次
            //     {
            //         if (numbers[j] > numbers[j + 1])
            //         {
            //             int temp = numbers[j];
            //             //第三方temp 接收 數值
            //             numbers[j] = numbers[j + 1];
            //             //交換數值
            //             numbers[j + 1] = temp;
            //         }
            //     }
            // }
            // foreach (var item in numbers )
            // {
            //     System.Console.WriteLine(item);
            // }



            // //輸入一個數字，確認是否為質數
            // System.Console.WriteLine("請輸入一個數字");
            // string input = Console.ReadLine();
            // int number = Convert.ToInt32(input);

            // if (number < 2)
            // {
            //     System.Console.WriteLine("不是質數");

            // }
            // else
            // {
            //     for (int i = 2; i < number - 1; i++)
            //     {
            //         if (number % i == 0)
            //         {
            //             System.Console.WriteLine("不是質數");
            //         }
            //     }
            //     System.Console.WriteLine("質數");
            // }

            //提示用戶輸入兩個數字，計算這兩個數字之間所有整數的和
            //1.用戶只能輸入數字
            //2.計算兩個數字之間的和
            //3.要求第一個數字必須比第二個數字小，否就重新輸入

            // System.Console.WriteLine("請輸入第一個數字");
            // string input1 = Console.ReadLine();
            // int n1 = Isnumber(input1);
            // System.Console.WriteLine("請輸入第二個數字");
            // string input2 = Console.ReadLine();
            // int n2 = Isnumber(input2);
            // vs(ref n1, ref n2);
            // int sum = numSum(n1, n2);
            // System.Console.WriteLine(sum);


            //登入帳號密碼，確認帳號和密碼是否為true，返回true or false
            //另外返回message 告知用戶訊息
            // System.Console.WriteLine("請輸入帳號");
            // string username = Console.ReadLine();
            // System.Console.WriteLine("請輸入密碼");
            // string pwd = Console.ReadLine();
            // string msg = "";
            // bool result = usernamepwd(username,pwd,out msg);

            // System.Console.WriteLine("登入結果{0} 登入訊息{1}",result,msg);







        }
        public static bool usernamepwd(string n1, string n2, out string msg)
        {
            if (n1 != "admin" && n2 != "123")
            {
                msg = "錯誤";
                return false;
            }
            else if (n1 != "admin" || n2 != "123")
            {
                msg = "錯誤";
                return false;
            }
            else
            {
                msg = "成功";
                return true;
            }
        }

        public static int Isnumber(string n)
        {
            while (true)
            {
                try
                {
                    int num = Convert.ToInt32(n);
                    return num;

                }
                catch
                {
                    System.Console.WriteLine("不是整數,重新輸入");
                    n = Console.ReadLine();

                }
            }

        }
        public static void vs(ref int n1, ref int n2)
        {
            while (true)
            {
                if (n1 > n2)
                {
                    System.Console.WriteLine("第一個數字必須比第二個數字小,請重新輸入第一個整數");
                    string s1 = Console.ReadLine();
                    n1 = Isnumber(s1);
                    System.Console.WriteLine("第一個數字必須比第二個數字小,請重新輸入第二個整數");
                    string s2 = Console.ReadLine();
                    n2 = Isnumber(s2);

                }
                else
                {
                    return;
                }
            }

        }
        public static int numSum(int n1, int n2)
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

