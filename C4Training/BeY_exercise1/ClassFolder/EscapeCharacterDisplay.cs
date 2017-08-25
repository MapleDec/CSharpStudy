using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beyond_exercise1
{
    class EscapeCharacterDisplay
    {
        public enum tt
        {
            grem,
            dre
        }
        public static void zhiBiaoFu()
        {
            tt t1 = tt.grem;
            tt t2 = tt.dre;
            Console.WriteLine("{0}, \t{1}", t1, (int)t1);
            Console.WriteLine("{0}, \t{1}", t2, (int)t2);
            Console.ReadKey();
        }
    }
}
