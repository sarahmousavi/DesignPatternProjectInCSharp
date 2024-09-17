using SingletonProject;

//استفاده از آن برای مدیریت شمارنده دریافت نمونه
Counter counter1 = Counter.Instance;
counter1.Increment();
counter1.Increment();
Console.WriteLine("Counter1:" + counter1.GetCount());
//خروجی :2

//  دریافت نمونه singleton   (همان نمونه قبلی را بر می گرداند) 
Counter counter2 = Counter.Instance;
counter2.Increment();
Console.WriteLine("Counter2:" + counter2.GetCount());
//خروجی:3

//بررسی اینکه آیا هر دو نمونه یکسان هستند
Console.WriteLine(object.ReferenceEquals(counter1, counter2));
//خروجی:true