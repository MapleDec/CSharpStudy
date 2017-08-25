/*
    异常： 程序运中的运行时错误，违反系统约束或程序约束，或出现了正常操作时未预料的情形。
    1.try 语句：被异常保护的代码块
      catch: 包含一个或多个catch 子句，处理异常的代码块
      finally: 在所有情况下都要被执行的代码块，无论异常有没有发生    
 */
using System;


namespace BasicKnowled.ClassFolder
{
    class YiChang
    {
        

        public  void test1()
        {
            int x = 7;
            try
            {
                int y = 0;
                x /= y;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
            }                
        }
    }
}
