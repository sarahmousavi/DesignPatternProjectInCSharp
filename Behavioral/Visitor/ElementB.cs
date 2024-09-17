using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace Visitor
{
    //پیاده سازی یک عنصر دیگر
    public class ElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string OperationB()
        {
            return "Operation ElementB";
        }
    }
}