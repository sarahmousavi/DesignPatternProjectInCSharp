using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe
{
    //این کلاس برای دریافت رویداد ثبت نام می کند
    public class Subscriber
    {
        private string _name;

        public Subscriber(string name)
        {
            _name = name;
        }
        //متدی که در هنگام دریافت رویداد فراخوانی می شود
        public void OnDataReceived(object sender, string data)
        {
            Console.WriteLine($"{_name} : Received data '{data}' ");
        }
    }
}