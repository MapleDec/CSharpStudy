using System;
using BasicKnowled.ClassFolder;

namespace BasicKnowled
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
            //TestAcess();
            //MethodApp();
            //Console.ReadKey();
            //ClassImprove.StaticMemberTest();
            //HomeMemberApp();
            //ClassInheritanApp();
            //YiChang map = new YiChang();
            //map.test1();
            //StructEnumEventApp();
            FenGeXian();
 
            DelegateEventApp();

            Console.ReadKey();
        }

        // Test access method from in or out
        private static void TestAcess()
        {
            AcessMemberIn eg00 = new AcessMemberIn();

            eg00.MathCaulate();
            //Console.WriteLine("{0}", eg00.MathCaulate);


            AcessMemberOut eg01 = new AcessMemberOut();
            eg01.chinses = 98;
            eg01.math = 93;
            eg01.english = 88;

            Console.WriteLine("All grade is {0}", eg01.SumGrade());
            Console.WriteLine("Average grade is {0}", eg01.GetAverage());

            Console.ReadKey();
        }

        // Test Method
        private static void MethodApp()
        {
            Console.WriteLine("-------------array as parameter-------------");
            int first = 4, second = 5, third = 6;
            int[] feilong = { 3, 7, 9 };
            MethodEg parameterArry01 = new MethodEg();
            parameterArry01.ExpandNum(first, second, third);
            Console.WriteLine("{0} ,{1} ,{2}", first, second, third);

            // array as argument
            Console.WriteLine("-------------array as argument-------------");
            parameterArry01.ExpandNum(feilong);
            foreach (var item in feilong)
            {
                Console.WriteLine("{0} ", item);
            }
            // method overload
            Console.WriteLine("-------------method overload-------------");
            MethodEg oveLoad = new MethodEg();
            oveLoad.SelfInstruction("Maple");
            oveLoad.SelfInstruction("Maple", "man", 23);
            oveLoad.SelfInstruction("Maple", "man", 23, "China Han city", "Star Sky");
            // parameter place can random
            Console.WriteLine("-------------parameter place can random-------------");
            MethodEg paraPlaceRan = new MethodEg();
            var outNum = paraPlaceRan.NumAdd(c: 7.9, a: 88.23, b: 33.1032);
            Console.WriteLine("Num is {0}", outNum);
            // cahnge parameter place and ignore someone parameter 
            var arrea = paraPlaceRan.AreaCylinderCacul(7.2);
            Console.WriteLine("Cylinder area is {0}", arrea);

            arrea = paraPlaceRan.AreaCylinderCacul(height: 87.9843);
            Console.WriteLine("Cylinder area is {0}", arrea);
        }

        // Test Class 
        // Test Constructor(构造函数) with parameters
        private static void HomeMemberApp()
        {
            HomeMember a = new HomeMember(),
                b = new HomeMember("Yang"),
                c = new HomeMember("Fei", "Woman", "22");

            a.OutputInfo();
            b.OutputInfo();
            c.OutputInfo();
        }
        // ClassInheritanApp
        private static void ClassInheritanApp()
        {
            // Test virtual method and override method
            WhiteHuman tom = new WhiteHuman();
            // Convert tom to base class(将 ton 强制转换成基类)
            Human ren = (Human)tom;
            tom.complexion = "white";
            tom.LoveFood();
            tom.Complexion();
            ren.LoveFood();
            Human ren2 = new Human();
            ren2.LoveFood();

            //

        }

        private static void StructEnumEventApp()
        {
            StructEnumEvent struct1 = new StructEnumEvent();
            //struct1.StructOutput();
            //struct1.RectangleArrayTestOut();
            //struct1.JiaoCuoArrayTestOut();
            struct1.ArrayPropertyOut();
        }
        private static void DelegateEventApp()
        {
            DelegateSource Bron = new DelegateSource();
            Bron.TestDelegate();
        }

        private static void FenGeXian()
        {
            Console.WriteLine("------------------------------");
        }
    }
}