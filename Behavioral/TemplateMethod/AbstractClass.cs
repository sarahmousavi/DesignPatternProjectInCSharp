using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    //کلاس انتزاعی که ساختار الگوریتم را تعریف می کند
    public abstract class AbstractClass
    {
        //ساختار کلی الگوریتم را تعریف می کند
        public void TemplateMethod()
        {
            Step1();
            Step2();    //متد اختیاری که ممکن است زیر کلاس ها بازنویس کنند
            Hook();
            Step3();
        }
         //مراحل مختلف الگوریتم که زیر کلاس ها می توانند بازنویسی کنند
        protected abstract void Step1();
        protected abstract void Step2();
        protected abstract void Step3();
        
        //متد اختیاری Hook که زیر کلاس ها می توانند آن را بازنویسی کنند  
        protected virtual void Hook() { }
    }
}