using PublishSubscribe;

namespace PublishSubscribeDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ایجاد ناشر
            Publisher publisher = new Publisher();
            //ایجاد مشترکان
            Subscriber subscriber1 = new Subscriber("Subscriber 1");
            Subscriber subscriber2 = new Subscriber("Subscriber 2");
            //ثبت نام مشترکان برای رویداد
            publisher.DataPublished += subscriber1.OnDataReceived;
            publisher.DataPublished += subscriber2.OnDataReceived;
            //انتشار داده
            publisher.Publish("First Message");
            publisher.Publish("Second Message");
            //لغو اشتراک یک مشترک
            publisher.DataPublished -= subscriber1.OnDataReceived;
            //انتشار داده پس از لغواشتراک
            publisher.Publish("Third Message");
        }
    }
}