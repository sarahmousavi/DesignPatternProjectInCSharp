using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //پیاده سازی واقعی محصولات برای فورد
    internal class FordSedan : ISedan
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Ford Sedan:Fusion");
        }
    }
}
