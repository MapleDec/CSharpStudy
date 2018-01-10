/*
 * 接口及接口继承
 * 1. 接口是一组函数成员而不实现函数成员的引用类型（类和结也构可以实现接口）
 * 2. 类是对象的抽象,接口是方法的抽象。如果方法跨越不同类的对象,可使用接口
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicKnowled.ClassFolder
{
    interface IParentInterface
    {
        void IParentInterfaceMethod();
    }
    interface IMyInterface : IParentInterface
    {
        void IMyInterfaceMethod();
    }
    public class IPlementInterface : IMyInterface
    {
        public void IPlementInterfaceMehod()
        {
            //IMyInterfaceMethod();
            //IParentInterfaceMethod();
            Console.WriteLine("IPlementInterfaceMehod() This is son.");
        }
        public void IMyInterfaceMethod()
        {
            Console.WriteLine("IMyInterfaceMethod() This is me.");
        }

        public void IParentInterfaceMethod()
        {
            Console.WriteLine("IParentIneterfaceMethod() This  is farther.");
        }
    }

}
