using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //پیاده سازی واقعی محصولات برای فورد
    public class FordSUV : ISUV
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Ford SUV:Explorer");
        }
    }
}
