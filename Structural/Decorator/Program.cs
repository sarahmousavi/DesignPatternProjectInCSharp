using Decorator;

namespace DecoratorDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ایجاد یک قهوه ساده
            ICoffee myCoffee = new SimpleCoffee();
            Console.WriteLine($"{myCoffee.GetDescription()} : {myCoffee.GetCost()}");
            //اضافه کردن شیر به قهوه
            myCoffee = new MilkDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.GetDescription()} : {myCoffee.GetCost()}");
            //اضافه کردن شکر به قهوه
            myCoffee = new SugarDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.GetDescription()} : {myCoffee.GetCost()}");
            //اضافه کردن خامه به قهوه
            myCoffee = new WhipDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.GetDescription()} : {myCoffee.GetCost()}");
        }
    }
}