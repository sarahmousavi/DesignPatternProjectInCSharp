using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace Visitor
{
    public class ConcreteVisitor2 : IVisitor
    {
        //پیاده سازی بازدیدکننده ی دیگر با عملیات متفاوت
        public void Visit(ElementA element)
        {
            Console.WriteLine($"{element.OperationA()} visited by ConcreteVisitor2");
        }

        public void Visit(ElementB element)
        {
            Console.WriteLine($"{element.OperationB()} visited by ConcreteVisitor2");
        }
    }
}