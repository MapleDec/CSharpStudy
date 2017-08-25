using System;
/*
 * 类 的定义 结构 成员访问，方法调用
 * 从类的内部/外部访问成员
 */
namespace BasicKnowled.ClassFolder
{
    // Acesss member from in
    public class AcessMemberIn
    {
        int chinses = 88;
        int math = 79;
        int english;

        private double SumGrade()
        {
            return (chinses + math + english);
        }
        private double GetAverage()
        {
            return (SumGrade() / 3);
        }

        public void MathCaulate()
        {
            Console.WriteLine("All grade is {0}", SumGrade());
            Console.WriteLine("Average grade is {0}", GetAverage());
        }
    }

    // Acesss member from Out
    public class AcessMemberOut
    {
        public int chinses = 88;
        public int math = 79;
        public int english;

        public double SumGrade()
        {
            return (chinses + math + english);
        }
        public double GetAverage()
        {
            return (SumGrade() / 3);
        }
    }
}

 