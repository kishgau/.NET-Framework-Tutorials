using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseClass baseObj = new BaseClass();

            baseObj.display1();
            baseObj.display2();



            Console.WriteLine("");
            ChildClass childObj = new ChildClass();

            childObj.display1();
            childObj.display2();

            //ChildClass childObj2 = new BaseClass();
            Console.WriteLine("");
            BaseClass baseObj2 = new ChildClass();
            baseObj2.display1();
            baseObj2.display2();
        }
    }


    class BaseClass
    {
        public void display1()
        {
            Console.WriteLine("base class display 1");
        }

        public virtual void display2()
        {
            Console.WriteLine("Base Class Display 2");
        }

    }
        class ChildClass : BaseClass
    {
        public new void display1()
        {
            Console.WriteLine("Child Class Display 1");
        }

        public override   void display2()
        {
            Console.WriteLine("CHild Class Display 2");
        }
    }


}
