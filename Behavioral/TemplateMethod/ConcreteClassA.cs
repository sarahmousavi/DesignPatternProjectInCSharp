using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod;

namespace TemplateMethod
{
    //زیر کلاس اول که مراحل الگوریتم را پیاده سازی می کند
    public class ConcreteClassA : AbstractClass
    {
        protected override void Step1()
        {
            Console.WriteLine("ConcreteClassA : Execute Step 1");
        }

        protected override void Step2()
        {
            Console.WriteLine("ConcreteClassA : Execute Step 2");
        }

        protected override void Step3()
        {
            Console.WriteLine("ConcreteClassA : Execute Step 3");
        }
    }
}