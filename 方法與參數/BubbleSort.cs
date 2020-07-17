using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCsharp
{ 

    public class PracticeBubbleSort
    {   
        public static void BubbleSort()
        {   /*
           int [] nums ={1,2,3,4,5,6,7,8,9} 
            example:                                    9 ----- nums.length
            1st:8 7 6 5 4 3 2 1 9 交換8次 i = 0  j = 8   j = nums.length-1-0      (j = nums.length-1-i)
            2nd:7 6 5 4 3 2 1 8 9 交換7次 i = 1  j = 7   j = nums.length-1-1      (j = nums.length-1-i)
            3rd:6 5 4 3 2 1 7 8 9 交換6次 i = 2  j = 6   j = nums.length-1-2      (j = nums.length-1-i)
            8次    
        **/
            //對數列升冪排序
            //Array.Sort(nums);
            //對數列反轉
            //Array.Reverse(nums);
            
            int[] nums = { 1, 5, 9, 7, 8, 6, 4, 2, 3, 11, 55, 88, 66, 44, 22 };
            for (int i = 0; i < nums.Length - 1; i++)
            {
                //  for (int j = 0; j < nums.Length - 1 - i; j++)
                //  手動減少交換次數
                for (int j = 0; j < nums.Length - 1; j++)  //第i次循環 總共循環numbers.length-1次
                {
                    if (nums[j] > nums[j + 1]) //開始交換 交換次數為 numbers.Length - 1 次
                    {
                        int temp = nums[j];
                        //第三方temp 接收 數值
                        nums[j] = nums[j + 1];
                        //交換數值
                        nums[j + 1] = temp;
                        //交換數值
                    }
                }

            }
            for (int i = 0; i < nums.Length - 1; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }

}
