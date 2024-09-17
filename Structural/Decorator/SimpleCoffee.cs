using Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //ConcreteComponent
    public class SimpleCoffee : ICoffee
    {
        public double GetCost()
        {
            return 5.0;
        }

        public string GetDescription()
        {
            return "Simple Coffee";
        }
    }
}