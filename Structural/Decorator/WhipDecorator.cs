﻿using Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternSample
{
    //Concrete Decorator3
    public class WhipDecorator : CoffeeDecorator
    {
        public WhipDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Whip";
        }

        public override double GetCost()
        {
            return base.GetCost() + 2.0;
        }
    }
}