using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beyond_exercise1
{
    class GestureGame
    {
        private const string WinMessage = "You Win.\n";
        private const string LostMessage = "You Lost.\n";
        private const string DrawMessage = "You Draw.\n";
        private const string KeepMessage = "Please give your gestures:";
        private const string InvalidMessage = "Input is invalid,Please give your gestures again.\n------Only input stone/shears/cloth------\n";

        // 统计各局情况以及分布
        private static int sum = 0, win = 0, lost = 0, draw = 0, invalidNum = 0;
        /// <summary>
        /// PC 随机手势   
        /// </summary>
        private enum EnumGesture
        {
            stone = 0,
            shears,
            cloth
        }
        public static void PlayGame()
        {
            Console.WriteLine("------Welcome join the game!------ \n------Only input stone/shears/cloth------");
            //StartGame();
            judgePlay();
        }

        /// <summary>
        /// 判断 是否进入游戏
        /// </summary>
        private static void judgePlay()
        {
            Console.WriteLine("Aou you sure play game ? Play/No?");            
            while (true)
            {
                string switchGame = Console.ReadLine();
                if (switchGame.ToUpper() == "PLAY")
                {
                    StartGame();
                    break;
                }
                else
                {
                    if (switchGame.ToUpper() == "NO")
                    {
                        Console.WriteLine("You will exist game.");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Invalid input, Please re-input again:");
                        Console.ResetColor();
                    }
                }
            }
        }
        public static void StartGame()
        {
            Console.WriteLine("--------------------------Game Start--------------------------------------");
            while (true)
            {
                Console.WriteLine(KeepMessage);
                string myGesture = Console.ReadLine();
                // 统计总局数
                sum++;

                if (myGesture.ToUpper() == "QUIT")
                {
                    Console.WriteLine("You have play {0} times, Win {1} times, Draw {2} times, Lost {3} times, Invalid {4} times", sum - 1, win, draw, lost, invalidNum);
                    Console.ReadKey();
                    break;
                }
                if (GestureChange(myGesture) == -1)
                {
                    invalidNum++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(InvalidMessage);
                    Console.ResetColor();
                    continue;
                }

                // my gesture     
                int myGestureValu;
                // PC gesture     
                int machineGesture;
                machineGesture = (int)RanomGesture();

                //手势结果转换
                myGestureValu = GestureChange(myGesture) - machineGesture;
                switch (myGestureValu)
                {
                    case 0:
                        myGestureValu = 0;
                        break;
                    case -1:
                    case 2:
                        myGestureValu = 1;
                        break;
                    case 1:
                    case -2:
                        myGestureValu = 2;
                        break;
                    default:
                        break;
                }
                SwitchJudge(myGestureValu);
            }
        }

        /// <summary>
        /// 根据差值判断输赢
        /// </summary>
        /// <param name="myGestureValu"></param>
        private static void SwitchJudge(int myGestureValu)
        {
            switch (myGestureValu)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(DrawMessage);
                    draw++;
                    Console.ResetColor();
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(WinMessage);
                    win++;
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(LostMessage);
                    lost++;
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 将输入的手势转换为数字代替
        /// </summary>
        /// <param name="inputGesture"></param>
        /// <returns></returns>
        private static int GestureChange(string inputGesture)
        {
            switch (inputGesture)
            {
                case "stone":                    
                    return 0;
                case "shears":                    
                    return 1;
                case "cloth":                    
                    return 2;
                default:                     
                    return -1;
            }
        }
        /// <summary>
        /// 随机获取一个手势并返回
        /// </summary>
        /// <returns></returns>

        private static EnumGesture RanomGesture()
        {
            Random random = new Random();
            int randomEnum = random.Next(3);
            EnumGesture machineGesture = (EnumGesture)randomEnum;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("PC gesture is : {0}", machineGesture);
            return machineGesture;
        }
    }
}