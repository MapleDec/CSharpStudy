using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Beyond_exercise1
{
    class GetChinese
    {

        private static int GetChineseCount(string inputCharacter)
        {
            int count = 0;
            string outPutString = string.Empty;
            // char[] c = inputCharacter.ToCharArray();
            Regex regex = new Regex(@"^[\u4E00-\u9FA5]{0,}$");
            for (int i = 0; i < inputCharacter.Length; i++)
            {
                if (regex.IsMatch(inputCharacter[i].ToString()))
                {
                    count++;
                    //outPutString += inputCharacter[i];
                    Console.WriteLine("---- {0} ---", inputCharacter[i]);
                }
            }
            return count;
        }

        public static void getChineseCountApp()
        {
            Console.WriteLine("------------------Please input a string--------------------");
            string inputString = "123gy杨光fd付fs";

            //string inputCharacter = Console.ReadLine();
            //Console.WriteLine("You input {0} character. ", inputString.Length);
            var a = GetChineseCount(inputString);

            Console.WriteLine(a);
            //Console.WriteLine("Chinese string is : {0}, it contain {1} words", outPutString, count);
            Console.ReadKey();
        }

    }
}
