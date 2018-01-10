/*     委托  事件
 * 1.委托：自定义的类型；类表示的式数据的集合，委托保存的是一个或多个方法；调用委托的时候其包含的每一个方法都会被执行；没有方法主体。
 *   delegate 返回类型 委托类型名(参数列表);
 * 2. 事件：触发-raise/fire 调用--invoke 发布者--publisher 订阅者--subscriber 事件处理程序-- event handler
 * 3. http://www.cnblogs.com/wudiwushen/archive/2010/04/20/1703368.html    
 */
using System;
using System.Threading;

namespace BasicKnowled.ClassFolder
{
    public delegate string TeaDelegate(string spText);
    class Operator
    {
        private bool waterFlag = true;
        public string GetTea(string spText)
        {
            if (spText == "Give me a cup of tea")
            {
                if (waterFlag)
                {
                    return "Your tea.";
                }
                else
                {
                    return "Sorry, there is no water.";
                }
            }
            else return "Waiting ... ...";
        }
        #region
        // 多播委托
        public string Speak(string spText)
        {
            Console.WriteLine("\nTake my chart");
            return null;
            //return "Give your chart";
        }
        #endregion
    }
    class DelegateSource
    {
        public void TestDelegate()
        {
            Operator op = new Operator();
            //TeaDelegate tea = new TeaDelegate(op.GetTea);         
            //TeaDelegate tea = op.GetTea;
            //--------------此为匿名委托，木有方法---------------
            #region              
            //bool waterFlag = true;
            //TeaDelegate tea = delegate (string spText)
            //{
            //    if (spText == "Give me a cup of tea")
            //    {
            //        if (waterFlag)
            //        {
            //            return "Your tea.";
            //        }
            //        else
            //        {
            //            return "Sorry, there is no water.";
            //        }
            //    }
            //    return "Waiting ...";
            //};  
            #endregion
            //多播委托
            #region
            TeaDelegate tea1 = op.GetTea;
            TeaDelegate tea2 = op.Speak;
            TeaDelegate tea = tea1 + tea2;
            // 多播委托连续调用多个方法，此处有返回值，所有最后只能得到委托调用的最后的一个方法的结果
            #endregion
            Console.WriteLine("Please give me a cup of tea.");
            string result = tea("Give me a cup of tea");
            Thread.Sleep(5000);
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }

    // 委托 1
    #region
    // class MrZhang
    public class MrZhang
    {
        // MrZhang is a sad people.
        public static void BuyCarTicket()
        {
            Console.WriteLine("NMD, he always ask me to bug ticket! fuc,,,,");
        }
        public static void BuyMovieTicket()
        {
            Console.WriteLine("NM, you date a girl, I bring movie ticket,,！");
        }
    }
    // class MrMing
    public class MrMing
    {
        // define a delegate, this is a "Command".
        public delegate void BuyTicketEventHandle();
        public static void DoThings()
        {
            // explanation this command what should to do
            // 委托的构造函数不为空，所以要加上委托的方法
            BuyTicketEventHandle myDelegate = new BuyTicketEventHandle(MrZhang.BuyCarTicket);

            myDelegate += MrZhang.BuyMovieTicket;

            // a specific method be attached to the delegate
            myDelegate();
            Console.ReadKey();
        }
    }
    #endregion

    // 委托 2    
    #region
    // 发布者
    public class PublisherHokage
    {
        // define a publisher's delegate
        public delegate void PublishEventHandle();
        // 委托机制下建立出版事件
        public event PublishEventHandle OnPublish;
        // 事件必须在方法里触发，出版社发布新书方法
        public void issue()
        {
            // 如果有人注册了这个事件
            if (OnPublish != null)
            {
                Console.WriteLine("The latest Hokage Ninjia will be released today.");
                OnPublish();
            }
        }
    }
    // Subscriber 订阅者
    public class MrYang
    {
        public static void Recive()
        {
            Console.WriteLine("Oh yeah, I have recived the latest Hokage Ninjia.");
        }
    }
    // Subscriber 订阅者
    public class MrYu
    {
        public static void Recive()
        {
            Console.WriteLine("You are a little child, we don't see Hokage Ninjia.");
        }
    }
    #endregion

    // 事件
    #region
    public class PubEventArgs : EventArgs
    {
        public readonly string magazineName;
        public PubEventArgs()
        {

        }
        public PubEventArgs(string magazineName)
        {
            this.magazineName = magazineName;
        }
    }

    //发布者（Publiser)
    public class PublishersEvents
    {
        //声明一个出版的委托
        //这里多了一个参数sender,它所代表的就是Subject，也就是监视对象，本例中就是Publisher
        public delegate void PublishEventHander(object sender, PubEventArgs e);
        //在委托的机制下我们建立以个出版事件
        public event PublishEventHander Publish;

        //声明一个可重写的OnPublish的保护函数
        protected virtual void OnPublish(PubEventArgs e)
        {
            if (Publish != null)
            {
                //Sender = this，也就是Publisher
                this.Publish(this, e);
            }
        }

        //事件必须要在方法里去触发
        public void issue(string magazineName)
        {
            OnPublish(new PubEventArgs(magazineName));
        }
    }
    //Subscriber 订阅者
    public class MrMi
    {
        //对事件感兴趣的事情
        public static void Receive(object sender, PubEventArgs e)
        {
            Console.WriteLine("Haha, I have recived the latest《" + e.magazineName + "》！！");
        }
    }

    public class MrZhao
    {
        //对事件感兴趣的事情
        public static void Receive(object sender, PubEventArgs e)
        {
            Console.WriteLine("Child，you are 21, we don't see《Hokage Ninjia》，SB Xiao Mi！");
            Console.WriteLine("This is my order《" + e.magazineName + "》，oh yeah！");
        }
    }
    #endregion

}
