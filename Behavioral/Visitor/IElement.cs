using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace Visitor
{
    //اینترفیس عنصر که پذیرش بازدید کننده را تعریف می کند
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}