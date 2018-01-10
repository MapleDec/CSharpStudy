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
           
            String operation = null;
            do
            {
                Console.WriteLine("What do you want to do? Please input number.");
                Console.WriteLine("1.LivedTime \t2.DeleteBlankSpace \t3.PlayGuesture \t4.GetChineseNum \t");
                operation = Console.ReadLine();
                
                switch (operation)
                {
                    case "1": LiveTime.GetLivedTime(); break;
                    case "2": ReplaceBlankKey.DeletAllSpace(); break;
                    case "3": GestureGame.PlayGame(); break;
                    case "4": GetChinese.getChineseCountApp(); break;

                    default: break;
                }
            
            } while (operation != "Quit");
             
            Console.WriteLine("execute completed!");
            Console.ReadKey();
        }
    }
}
