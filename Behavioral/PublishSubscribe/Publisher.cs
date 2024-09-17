using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe
{
    //این کلاس رویداد را تعریف می کند
    public class Publisher
    {
        //تعریف رویداد با استفاده از دلیگیت
        public event EventHandler<string> DataPublished;
        //متدی که رویداد را منتشر می کند
        public void Publish(string data)
        {
            Console.WriteLine($"Publisher : Publishing data '{data}'...");
            OnDataPublished(data);
        }
        //متدی برای فراخوانی رویداد
        protected virtual void OnDataPublished(string data)
        {
            //بررسی اینکه آیا رویدادی وجود دارد یا خیر
            DataPublished?.Invoke(this, data);
        }
    }
}