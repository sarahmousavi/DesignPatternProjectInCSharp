using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace Visitor
{
    //پیاده سازی بازدیدکننده ای که عملیات خاصی را روی عناصر انجام می دهد
    public class ConcreteVisitor1 : IVisitor
    {
        public void Visit(ElementA element)
        {
            Console.WriteLine($"{element.OperationA()} visited by ConcreteVisitor1");
        }

        public void Visit(ElementB element)
        {
            Console.WriteLine($"{element.OperationB()} visited by ConcreteVisitor1");
        }
    }
}