/*     委托  事件
 * 1.委托：自定义的类型；类表示的式数据的集合，委托保存的是一个或多个方法；调用委托的时候其包含的每一个方法都会被执行；没有方法主体。
      delegate 返回类型 委托类型名(参数列表);         
 */
using System;
using System.Threading;

namespace BasicKnowled.ClassFolder
{
    public delegate string TeaDelegate(string spText);
    class Operator
    {
        private bool waterFlag = true;
        public string GetTea(string sqText)
        {
            if (sqText == "Give me a cup of tea")
            {
                if (waterFlag)
                { return "Your tea."; }
                else { return "Sorry, there is no water."; }
            }
            else return "Waiting ... ...";
        }
    }
    class DelegateSource
    {
        public void TestDelegate()
        {
            Operator op = new Operator();
            TeaDelegate tea = new TeaDelegate(op.GetTea);
            //TeaDelegate tea =op.GetTea;
            Console.WriteLine("Please give me a cup of tea.");
            Console.WriteLine();
            string result = tea("Give me a cup of tea");
            Thread.Sleep(5000);
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
