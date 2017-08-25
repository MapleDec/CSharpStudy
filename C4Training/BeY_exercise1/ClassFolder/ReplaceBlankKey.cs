using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beyond_exercise1
{
    class ReplaceBlankKey
    {
        public static void DeletAllSpace()
        {
            string maple = " Ma ple Yang ";
            string[] mapleArray = maple.Split(new char[] { ' ' });
            Console.Write("Array achieve: ");
            foreach (string temp in mapleArray)
                Console.Write(temp);
            Console.WriteLine();

            //Direct delete all blankSpace   
            maple = maple.Replace(" ", "");
            Console.WriteLine("Delete all blankSpace: " + maple);

            //Delete the top and end blank space;
            maple = " MapleYang ";
            maple = maple.Trim();
            Console.WriteLine("Delete top and end blank space: " + maple);

            Console.ReadKey();
        }
    }
}
