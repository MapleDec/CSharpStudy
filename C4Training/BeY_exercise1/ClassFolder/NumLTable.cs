using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeY_exercise1
{
    class NumLTable
    {
        /// <summary>
        /// 随机获得 num 个数 范围为 minvalue~maxvalue
        /// </summary>
        /// <param name="num"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        private static int[] GetRandomNum(int num, int minValue, int maxValue)
        {
            Console.Write("产生的{0}个随机数为:", num);

            Random ra = new Random(unchecked((int)DateTime.Now.Ticks));
            int[] arrNum = new int[num];
            int tmp = 0;
            for (int i = 0; i <= num - 1; i++)
            {
                //随机取数
                tmp = ra.Next(minValue, maxValue);
                //取出值赋到数组中
                arrNum[i] = GetNumber(arrNum, tmp, minValue, maxValue, ra);
                //Console.Write(num[i] + "\0");
            }
            return arrNum;
        }
        /// <summary>
        /// 检验随机获得 nun 个数组是否符合
        /// </summary>
        /// <param name="arrNum"></param>
        /// <param name="tmp"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <param name="ra"></param>
        /// <returns></returns>
        private static int GetNumber(int[] arrNum, int tmp, int minValue, int maxValue, Random ra)
        {
            int n = 0;
            while (n <= arrNum.Length - 1)
            {
                //利用循环判断是否有重复
                if (arrNum[n] == tmp)
                {
                    //重新随机获取
                    tmp = ra.Next(minValue, maxValue);
                    //递归:如果取出来的数字和已取得的数字有重复就重新随机获取
                    GetNumber(arrNum, tmp, minValue, maxValue, ra);
                }
                n++;
            }
            return tmp;
        }
        /// <summary>
        /// 随机获得几个数 应用
        /// </summary>
        public static void GetRandomNumApp()
        {
            //Console.WriteLine("Do you want to get a few numbers? Please input count and minvalue, maxvalue.");
            //int a = Console.Read();
            //int b = Console.Read();
            //int c = Console.Read();
            Console.WriteLine("-----产生所需随机数----");
            var Num001 = GetRandomNum(10, 1, 15000);
            for (int i = 0; i < +Num001.Length - 1; i++)
            {
                Console.Write(Num001[i] + "\t");
            }
            Console.WriteLine();
            GetMinValue(Num001);
        }

        /// <summary>
        /// 获取数组的中的最小值
        /// </summary>
        /// <param name="exampleArrayNum"></param>
        private static void GetMinValue(int[] exampleArrayNum)
        {
            for (int i = 0; i <= exampleArrayNum.Length - 1; i++)
            {
                for (int j = i + 1; j < exampleArrayNum.Length - 1; j++)
                {
                    int temp;
                    if (exampleArrayNum[i] > exampleArrayNum[j])
                    {
                        temp = exampleArrayNum[i];
                        exampleArrayNum[i] = exampleArrayNum[j];
                        exampleArrayNum[j] = temp;
                    }
                }
            }
            Console.WriteLine("The array minvalue is {0}", exampleArrayNum[0]);
        }
    }
}
