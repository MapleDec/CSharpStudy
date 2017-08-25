/* 结构 枚举 事件        
    1.结构：值类型，隐式密封，不能被派生；不允许初始化字段；变量不能为null；两个结构变量不能引用同一对象；预定义无参构造不能删除/重定义  
      复制：从一个结构中把值复制到另一个结构；
      返回值：结构做返回值，一个复制被创建并从函数成员返回。
      值参：。。。一个世纪参数的复制被创建。
      ref/out:一个对结构的引用被传入方法
    2.枚举/enum：成员隐式编号默认递增
    3.数组：一旦创建，大小就固定；不支持动态数组；是对象；
      交错数组：数组的数组，子数组可以有不同数目的元素;必须为交错数组中的每一个维度使用独立的foreach语句，且foreach语句必须嵌套确保每一个嵌套数组都被正确处理；
    4.数组协变：某些情况下，某个对象不是数组的基类型吗，仍然可以把它赋值给数组元素。数组是引用类型数组；在赋值的对象类型和数组基类型之间有隐式转换或显示转换
    
 */
using System;

namespace BasicKnowled.ClassFolder
{
    struct BackHome
    {
        public string orign;
        public string aim;
        public double distance;
        public double spendTime;
        /// <summary>
        /// 结构的有参构造函数
        /// <summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        public BackHome(string a, string b, double c, double d)
        {
            orign = a;
            aim = b;
            distance = c;
            spendTime = d;
        }
    }

    class StructEnumEvent
    {
        BackHome xiaoMing;
        BackHome xiaoHua = new BackHome("Xian", "Shenzhen", 1200.32, 9.8);

        // rectangle array
        int[] number = new int[] { 3, 4, 23, 51, 12, 7 };
        int[,] number1 = new int[4, 3];
        int[,] number2 = new int[2, 3] { { 1, 5, 5 }, { 2, 5, 7 } };


        //int[,] number2 = { { 1, 5, 5 }, { 2, 5, 7 } };
        // 矢量
        double[,] vector = new double[2, 3] { { 1, 5, 6 }, { 7, 5, 9 } };
        double[,,] location = new double[,,] {
                                                { {1.2,2.2,4.0 } },
                                                { {1.64,5.45,3.48 } },
                                                { {44.7,21.5,62.2 } },
                                                { { 52.2,62.6,17.7} }
                                             };
        // 交错数组
        int[][] number3 = new int[2][];

        public object copy { get; private set; }

        public void StructOutput()
        {
            xiaoMing.orign = "Ankang";
            xiaoMing.aim = "Lijiang";
            xiaoMing.distance = 1632.45;
            xiaoMing.spendTime = 17.6;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("XiaoMing will leave {0} and go to {1}, it is {2}Km from here. It will take {3} hours", xiaoMing.orign, xiaoMing.aim, xiaoMing.distance, xiaoMing.spendTime);
            Console.WriteLine("XiaoHua will leave {0} and go to {1}, it is {2}Km from here. It will take {3} hours", xiaoHua.orign, xiaoHua.aim, xiaoHua.distance, xiaoHua.spendTime);
            Console.ResetColor();
        }

        /// <summary>
        /// Test RectangleArray app
        /// </summary>
        public void RectangleArrayTestOut()
        {
            Console.WriteLine("\nOutput Rectangle array:");
            int i = 0;
            foreach (double item in location)
            {
                i++;
                Console.WriteLine("{0}th value is {1}.", i, item);
            }
            Console.WriteLine("Output Rectangle array: Completed!\n");
        }
        public void JiaoCuoArrayTestOut()
        {
            int a = 0;
            //// 交错数组的初始化只能在方法成员内部
            //number3[0] = new int[] { 14, 25, 61 };
            //number3[1] = new int[] { 7, 24, 33, 49 };
            int[][] number4 = new int[3][];
            number4[0] = new int[] { 11, 53, 3 };
            number4[1] = new int[] { 23, 43, 12, 967 };
            number4[2] = new int[] { 432, 54, 543, 245, 34, 34 };

            foreach (var ite in number4)
            {
                Console.WriteLine("Start new array:");
                foreach (var ite1 in ite)
                {
                    a++;
                    Console.WriteLine("{0}th value is {1}", a, ite1);
                }
            }
        }

        private static void PrintArray(int[] a)
        {
            foreach (var x in a)
                Console.Write("{0}  \t", x);
            Console.WriteLine("");
        }
        public void ArrayPropertyOut()
        {
            Console.WriteLine("Print orign array: ");
            PrintArray(number);

            Console.WriteLine("Print array sort by: ");
            Array.Sort(number);
            PrintArray(number);

            Console.WriteLine("Print array sort by Nixu: ");
            Array.Reverse(number);
            PrintArray(number);

            //数组复制 Copy(),CopyTo()
            int[] numberCopy = new int[number.Length];
            int[] numberCopy1 = new int[number.Length];
            int[] numberCopy2 = (int[])number.Clone();

            Array.Copy(number, numberCopy, number.Length);
            Console.WriteLine("Print copy/copyTo/Clone array: ");
            PrintArray(numberCopy);

            number.CopyTo(numberCopy1, 0);
            PrintArray(numberCopy1);

            PrintArray(numberCopy2);

            Console.WriteLine("Rank={0}, Length = {1}, GetLenth(0) = {2}, GetTypr() = {3}", number.Rank, number.Length, number.GetLength(0), number.GetType());
            // Clear 3 items from index 1 start  
            Console.WriteLine("Clear specified element from specified position: ");
            Array.Clear(number, 1, 3);
            PrintArray(number);
        }
    }
}
