using System;


namespace Chess
{
    class Program
    {
        static int[] Maps = new int[100];
        //聲明玩家座標
        static int[] PlayerPos = new int[2];
        static string[] PlayerNames = new string[2];
        static bool[] Flags = new bool[2];
        static void Main(string[] args)
        {
            GameShow();
            #region 輸入玩家姓名
            Console.WriteLine("請輸入玩家A姓名");
            PlayerNames[0] = Console.ReadLine();
            while (PlayerNames[0] == "")
            {
                Console.WriteLine("請填寫玩家A姓名，請重新輸入");
                PlayerNames[0] = Console.ReadLine();
            }
            Console.WriteLine("請輸入玩家B姓名");
            PlayerNames[1] = Console.ReadLine();
            while (PlayerNames[1] == "" || PlayerNames[0] == PlayerNames[1])
            {
                if (PlayerNames[1] == "")
                {
                    Console.WriteLine("請填寫玩家B姓名，請重新輸入");
                    PlayerNames[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家A不能與玩家B姓名相同，請重新輸入");
                    PlayerNames[1] = Console.ReadLine();
                }
            }

            #endregion
            //玩家輸入成功，清理畫面
            Console.Clear();
            GameShow();
            Console.WriteLine($"{PlayerNames[0]}的士兵為A");
            Console.WriteLine($"{PlayerNames[1]}的士兵為B");
            InitailMap();
            DrawMap();

            //當玩家A跟玩家B沒有一個人在終點時，繼續玩遊戲
            while (PlayerPos[0] < 99 && PlayerPos[1] < 99)
            {
                if (Flags[0] == false)
                {
                    PlayGame(0);
                }
                else
                {
                    Flags[0] = false;
                }
                if (PlayerPos[0] >= 99)
                {
                    Console.WriteLine($"玩家{PlayerNames[0]}獲勝!!!");
                    break;
                }

                if (Flags[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    Flags[1] = false;
                }
                if (PlayerPos[1] >= 99)
                {
                    Console.WriteLine($"玩家{PlayerNames[1]}獲勝!!!");
                    break;
                }
            }//while
            Console.ReadKey(true);


        }


        public static void PlayGame(int playerNumber)
        {   //[playerNumber] = 0 ,[1-playerNumber] = 1
            Random r = new Random();
            int rnumber = r.Next(1, 7);
            Console.WriteLine($"{PlayerNames[playerNumber]}按任意鍵擲骰子");
            Console.ReadKey(true);
            Console.WriteLine($"{PlayerNames[playerNumber]}擲出了{rnumber}");
            PlayerPos[playerNumber] += rnumber;
            ChangePos();
            Console.ReadKey(true);
            Console.WriteLine($"{PlayerNames[playerNumber]}按任意鍵開始行動");
            Console.ReadKey(true);
            Console.WriteLine($"{PlayerNames[playerNumber]}行動結束");
            Console.ReadKey(true);
            if (PlayerPos[playerNumber] == PlayerPos[1 - playerNumber])
            {
                Console.WriteLine($"玩家{PlayerNames[playerNumber]}踩到了玩家{PlayerNames[1 - playerNumber]},玩家{PlayerNames[1 - playerNumber]}退6格");
                PlayerPos[1 - playerNumber] -= 6;
                ChangePos();
                Console.ReadKey(true);
            }
            else//踩到關卡
            {
                switch (Maps[PlayerPos[playerNumber]])
                {
                    case 0:
                        Console.WriteLine($"玩家{PlayerNames[playerNumber]}踩到方塊,安全");
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine($"玩家{PlayerNames[playerNumber]}踩到幸運輪盤,請選擇1--交換位置 2--轟炸對方");
                        string input = "";
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine($"玩家{PlayerNames[playerNumber]}選擇跟玩家{PlayerNames[1 - playerNumber]}交換位置");
                                Console.ReadKey(true);
                                int temp = PlayerPos[playerNumber];
                                PlayerPos[playerNumber] = PlayerPos[1 - playerNumber];
                                PlayerPos[1 - playerNumber] = temp;
                                Console.WriteLine("交換完成!!按任意鍵繼續遊戲!!!");
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine($"玩家{PlayerNames[playerNumber]}選擇轟炸玩家{PlayerNames[1 - playerNumber]}");
                                Console.ReadKey(true);
                                PlayerPos[1 - playerNumber] -= 6;
                                ChangePos();
                                Console.WriteLine($"玩家{PlayerNames[1 - playerNumber]}退了6格");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("只能選擇1或者2 請選擇1--交換位置 2--轟炸對方");
                                input = Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine($"玩家{PlayerNames[playerNumber]}踩到地雷,退6格");
                        Console.ReadKey(true);
                        PlayerPos[playerNumber] -= 6;
                        ChangePos();
                        break;
                    case 3:
                        Console.WriteLine($"玩家{PlayerNames[playerNumber]}暫停,暫停一回合");
                        Flags[playerNumber] = true;
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine($"玩家{PlayerNames[playerNumber]}踩到時空隧道,前進10格");
                        Console.ReadKey(true);
                        PlayerPos[playerNumber] += 10;
                        ChangePos();
                        break;
                }//switch
            }//else
            ChangePos(); //其實只需在清畫面前調用
            Console.Clear();
            DrawMap();
        }
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*****跳跳棋遊戲*****");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("********************");
        }

        public static void InitailMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 }; //幸運輪盤=1
            for (int i = 0; i < luckyturn.Length; i++)
            {
                Maps[luckyturn[i]] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 }; //地雷=2
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 }; //暫停=3
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 }; //傳送門=4
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }

        }

        public static void DrawMap()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("圖例 : 幸運輪盤 : ◎  地雷 : ☆  暫停 : ▲  傳送門 : 卍");
            #region 第一橫行

            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();
            #endregion

            #region 第一豎行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j <= 28; j++)
                {
                    Console.Write("  ");

                }
                Console.Write(DrawStringMap(i));
                Console.WriteLine();
            }
            #endregion

            #region 第二橫行
            for (int i = 64; i >= 35; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();
            #endregion

            #region 第二豎行
            for (int i = 65; i <= 69; i++)
            {
                Console.WriteLine(DrawStringMap(i));
            }
            #endregion

            #region 第三橫行
            for (int i = 69; i < 99; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();
            #endregion
        }

        #region 畫圖標
        public static string DrawStringMap(int i)
        {
            string str = "";
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == i)
            {
                str = "<>";
            }
            else if (PlayerPos[0] == i)
            {
                str = "Ａ";
            }
            else if (PlayerPos[1] == i)
            {
                str = "Ｂ";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        str = "□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "◎";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        str = "☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str = "卍";
                        break;

                }//switch
            }//if
            return str;


        }
        #endregion

        public static void ChangePos()
        {
            if (PlayerPos[0] < 0)
            {
                PlayerPos[0] = 0;
            }
            if (PlayerPos[0] >= 99)
            {
                PlayerPos[0] = 99;
            }
            if (PlayerPos[1] < 0)
            {
                PlayerPos[1] = 0;
            }
            if (PlayerPos[1] >= 99)
            {
                PlayerPos[1] = 99;
            }
        }
    }
}
