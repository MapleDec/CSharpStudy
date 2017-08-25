/*     类 继承
   1. 基类；派生类不能删除继承自基类的成员；符号 :
      单继承：声明的基类规格只有一个单独的类；
      隐藏基类成员：声明一个同基类同名称同类型的新成员，可隐藏/掩盖继承的成员，需用new 告诉编译器；可隐藏静态成员
      基类访问：base.成员名称可完全的访问被隐藏的成员
   2. 所有类都派生来自特殊类 object：object 是唯一的非派生类，没有基类的规格声明隐式的直接派生自类object
   3. 构造函数初始化语句： this,base.
      base: 使用并指明使用哪一个基类构造函数
      this: 使用并指明应使用当前类的哪一个另外的构造函数
   4. internal：内部类
   5. 类修饰符访问级: public > protected internal (受保护内部) > protected/internal > private
      未指定访问级别成员，隐式访问级别为private；成员不能比他的类更可访问；
      public: 所有的类都可以自由地访问成员
      private: 限制最严格 只能被他自己的类成员访问，不能被其他类(包括继承的类)访问；可被嵌套在它的类中的类的成员访问
      protected: 与private 类似，但允许它的派生类访问改成员。
      internal： 只对程序集内部的所有类可见，但对程序集外部的类不可见 
      protected internal：对所有继承自该类的类及所有程序集内部的类可见       
   6. abstract: 抽象；抽象类与抽象成员设计来就是为了被继承；抽象类可以派生自另一个抽象类
   7. sealed: 密封类只能被用作独立的类，不能作为基类
   8. 静态类：static 声明，静态类的所有成员都是静态的，用于分组不受实例数据影响的数据和函数。
 */

using System;
 
namespace BasicKnowled.ClassFolder
{
    class Human
    {
        private string name = "Yang Yue";
        private string sex;
        private string birthday;
        public string complexion;
        private int height;
                  
         virtual public void LoveFood()
        {
            Console.WriteLine("{0} likes to eat rice.", name);
        }
    }
     
    class WhiteHuman : Human
    {
        public string name = "Weal Yangchen";
        //new public int height;
        override public void LoveFood()
        {
            // 调用基类的方法
            //base.LoveFood();
            Console.WriteLine("{0} likes to eat bread and milk.", name);
        }
        virtual public void Complexion()
        {
            Console.WriteLine("The complexion is {0}.", base.complexion);
        }
    }
    class BlackHuam : WhiteHuman
    {
        public override void Complexion()
        {
            base.Complexion();
        }
        public override void LoveFood()
        {
            Console.WriteLine("{0} likes to eat orange.", base.name);
        }
    }
}
