using BeY_exercise1;
using System;
 

namespace Beyond_exercise1
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
            //LiveTime.GetLivedTime();          
            //ReplaceBlankKey.DeletAllSpace();

            //GestureGame.PlayGame();
            // GetChinese.getChinese();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1.LivedTime \t2.DeleteBlankSpace \t3.PlayGuesture \t4.GetChineseNum \t");
            String operation = Console.ReadLine();
            switch (operation)
            {
                case "LivedTime": LiveTime.GetLivedTime(); break;
                case "DeleteBlankSpace": ReplaceBlankKey.DeletAllSpace(); break;
                case "PlayGuesture": GestureGame.PlayGame(); break;
                case "GetChineseNum": GetChinese.getChineseCountApp(); break;
                
                default: break;
            }

            
            Console.ReadKey();
        }

    }
}
