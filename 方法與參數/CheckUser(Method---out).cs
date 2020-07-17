using System;


namespace FirstCsharp
{   //在一個方法中返回多個相同類型值，可以考慮返回一個陣列
    //Out 參數: 側重於在一個方法中，可以返回多個不同類型值
    //如果返回多個不同類型值時候，返回陣列就不行，這時候可以考慮使用 Out參數

    public class CheckUSer
    {   //登入帳號密碼，確認帳號和密碼是否為true，返回true or false
        //另外返回message 告知用戶訊息
        //使用out 參數
        public static bool Checkuser(string username, string pwd, out string msg)
        {
            if (username == "admin" && pwd == "admin")
            {
                msg = "登入成功";
                return true;
            }
            else if (username == "admin" && pwd != "admin")
            {
                msg = "密碼錯誤";
                return false;
            }
            else if (username != "admin" & pwd == "admin")
            {
                msg = "帳號錯誤";
                return false;
            }
            else
            {
                msg = "沒一個對";
                return false;
            }
        }
    }

}
