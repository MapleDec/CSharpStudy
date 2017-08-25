/*
 * 方法 相关
 * 1. 方法体包括：内部变量(生存于声明是所在的块)，控制流结构， 方法调用，内嵌的块
 * 2. 方法重载：具有相同方法名称的多个方法，实现功能的签名互不相同
 * 3. 命名参数：通常形参实参的位置一一对应，现在，位置可以任意，但需要显示指定参数的名字
 * 4. 可选参数：值类型的默认值在编译时可以确定，引用类型默认值为null 才可以使用；方法在调用是可以省略它；
 *    必须从可选参数列表的最后开始省略，直到列表开头；结合 step3 ，可以省略任意位置可选参数
 */
using System;

namespace BasicKnowled.ClassFolder
{
    class MethodEg
    {
        // Member constant 
        private const double Pl = 3.14159;
        // How to use paranmeter array
        public void ExpandNum(params int[] inVals)
        {
            if ((inVals != null) && (inVals.Length != 0))
                for (int i = 0; i < inVals.Length; i++)
                {
                    inVals[i] = inVals[i] * 10;
                    Console.WriteLine("{0} ", inVals[i]);
                }
        }

        // this is method overload 
        public void SelfInstruction(string name)
        {
            Console.WriteLine("I am {0}.", name);
        }
        public void SelfInstruction(string name, string sex, int age)
        {
            Console.WriteLine("I am {0}, {1}, {2} years old.", name, sex, age);
        }
        public void SelfInstruction(string name, string sex, int age, string homeTown, string likeWho)
        {
            Console.WriteLine("I am {0}, {1}, {2} years old. I'm from {3}, {4} is my Venus.", name, sex, age, homeTown, likeWho);
        }

        // 
        public double NumAdd(double a, double b, double c)
        {
            return (a + b + c);
        }
        public double AreaCylinderCacul(double radius = 6.23, double height = 4.32)
        {
            return 2 * Pl * radius * height;
        }
    }
}
