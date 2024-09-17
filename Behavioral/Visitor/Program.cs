using Visitor;

namespace Visitor
{
    public class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure structure = new ObjectStructure();

            //افزودن عناصر به ساختار
            structure.Add(new ElementA());
            structure.Add(new ElementB());

            //ایجاد بازدید کننده ها
            ConcreteVisitor1 visitor1 = new ConcreteVisitor1();
            ConcreteVisitor2 visitor2 = new ConcreteVisitor2();

            //اجرای بازدیدکننده ها بر روی عناصر
            Console.WriteLine("using ConcerteVisitor1 : ");
            structure.Accept(visitor1);

            Console.WriteLine("Using ConcreteVisitor2 : ");
            structure.Accept(visitor2);
        }
    }
}