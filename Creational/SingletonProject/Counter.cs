
namespace SingletonProject
{
    public class Counter
    {
        //یک فیلد استاتیک برای نگهداری نمونه
        private static Counter _instance;

        //یک شیء برای مدیریت قفل در زمان ایجاد نمونه 
        private static readonly object _lock = new object();

        //که به عنوان شمارنده استفاده می شود و یک متغیر می باشد
        private int _count;

        //سازنده خصوصی برای جلوگیری از ایجاد نمونه های جدید
        private Counter()
        {
            //مقدار اولیه شمارنده
            _count = 0;

        }
        //متد استاتیک برای دسترسی به نمونه 
        public static Counter Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Counter();
                    }
                }
                return _instance;

            }

        }
        //متد برای افزایش مقدار شمارنده
        public void Increment()
        {
            _count++;
        }
        //متد برای دریافت مقدار فعلی شمارنده
        public int GetCount()
        {
            return _count;
        }

    }
}





