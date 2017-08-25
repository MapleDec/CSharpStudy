/* 类进阶：类的成员，字段，变量，类型，构造函数，索引，this，访问其
    1. 类：静态(static)/非静态 非静态类的成员访问：类名.方法名
    2. 静态：虽然类没有示例，但存在静态成员，仍然可以访问
    3. 常量没有自己的存储位置，编译时被编译器转换。常量成员表现像一个静态常量，但不能声明static.
    4. 实例构造函数：一种特殊的方法，在类的每个新实例创建的时候执行
           构造函数用于初始化类实例子的状态; 若需从类的外部创建类的实例须生明构造函数为public;构造函数名称和类名相同；构造函数不能有返回值
    5. 构造函数可以带参数(参数语法和其他完全相同)/被重载;
       默认构造函数不带参数，方法提为空(一旦声明了/至少有一个显示定义的任何构造函数，编译器将不会为该类定义默认构造函数)
    6. 析构函数执行在类的实例被销毁前需要的清理或释放托管资源的行为。
           :每个类只有一个析构函数；不能带参数；不能带访问修饰符；和类有相同的名称,前缀~；只能对类的实例起作用，没有静态析构函数；不能在代码中显示的调用。
           :不需要就不用执行析构函数，否则会带来性能上的开销；不应该访问其他对象，因为你不能假设那些对象没有被回收
    7. readonly作用类似声明一个字段const，值设定后不可更改；类的任何构造函数，若是static字段，初始化必须在static构造函数中完成。
           :字段值可以在运行时确定;可以是实例字段/静态字段；内存中有存储位置
    8. this: 在类中使用，是对当前实例的引用。只能存在下列类成员的代码块：实例构造函数/实例方法/属性和索引的实例访问器
           : 静态成员不是实例的一部分，所以不能在人恶化静态成员的代码中使用this 关键字
       目的: 用于区分累的成员和本地变量/参数；作为调用方法的实参 
    9. 索引: 一组set/get 访问器，类似于属性的访问器。 
           : 索引是实例成员，不能被声明为static；可以重载；默认情况下成员的两个访问器具有和成员自身相同的访问级别，访问器的级别可以自己编辑设定 
         声明索引注意: 没有名称，名称位置是关键字this;参数列表在方括号中间；至少必须声明一个参数
 */
using System;

namespace BasicKnowled.ClassFolder
{
    public class ClassImprove
    {
        private const double lightRate = 3 * 10e8;
        public static void StaticMemberTest()
        {
            Console.WriteLine("{0} ", lightRate);
        }
        public static void FourSideArea(double a, double b)
        {
            Console.WriteLine("Rectangle Area is {0}", a * b);
        }
        public static void FourSideArea(double a, double b, double du)
        {
            // 平行四边形
            Console.WriteLine("Parallelogram Area is {0}", a * b * (Math.Sin(Math.PI / du)));
        }
        public static void FourSideArea(double a, double b, double c, double du)
        {
            // 梯形
            Console.WriteLine("Trapezoid Area is {0}", 1 / 2 * a * (b + c) * (Math.Sin(Math.PI / du)));
        }

    }
    // Test 构造函数 
    class HomeMember
    {
        public string member;
        public string sex;
        public string age;

        // 索引示例
        public string this[int index]
        {
            set
            {
                switch (index)
                {
                    case 0: member = value; break;
                    case 1: sex = value; break;
                    case 2: age = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
            get
            {
                switch (index)
                {
                    case 0: return member;
                    case 1: return sex;
                    case 2: return age;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }

        }

        // Constructor(构造函数) with parameters
        public HomeMember() { member = "Maple"; sex = "Man"; age = "24"; }
        public HomeMember(string member_) { member = member_; sex = "Man"; age = "24"; }
        public HomeMember(string member_, string sex_, string age_) { member = member_; sex = sex_; age = age_; }

        public void OutputInfo()
        {
            Console.WriteLine("Name is {0}, sex is {1}, age is {2}", member, sex, age);
        }
    }

}
