using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beyond_exercise1
{
    class Human
    {
        public string name;
        public string sex;
        public int age;
        
        public virtual void EatMethod()
        {
            Console.WriteLine("Eating");
        }
        public virtual void Work()
        {
            Console.WriteLine("Working");
        }
    }
    class YellowMan : Human
    {
        public string skinColor;
        public string SkinColor
        {
            get { return SkinColor; }
            set { SkinColor = value; }
        }
        public override void EatMethod()
        {
            Console.WriteLine("Eat use Chopsticks. ");
        }
        public override void Work()
        {
            base.Work();
            Console.WriteLine("Work in Shanghai.");
        }
    }

    class BlackMan : Human
    {
        public string countryNum;

        public override void EatMethod()
        {
            base.EatMethod();
        }
        public override void Work()
        {
            base.Work();
        }
    }
}

