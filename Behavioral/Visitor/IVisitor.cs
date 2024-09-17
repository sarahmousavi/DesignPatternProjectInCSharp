using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Visitor
{
    //تعریف اینترفیس بازدید کننده
    public interface IVisitor
    {
        void Visit(ElementA element);
        void Visit(ElementB element);
    }
}