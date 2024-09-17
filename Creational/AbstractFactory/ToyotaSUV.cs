using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //پیاده سازی واقعی محصولات برای تویوتا
    public class ToyotaSUV : ISUV
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Toyota SUV:HighLander");
        }
    }
}
