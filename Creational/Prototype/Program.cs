using Prototype;
//ایجاد یک نمونه اولیه از خودرو
Car originalCar=new Car("Tesla Model S","Red",1000);
//ایجاد یک کپی از خودرو با استفاده از متد clone
Car clonedCar=(Car)originalCar.Clone();

//نمایش اطلاعات خودرو
Console.WriteLine("Original Car:" + originalCar);
Console.WriteLine("Cloned Car:" + clonedCar);

//تغییر در کپی بدون تاثیر در نمونه اصلی
clonedCar.Color = "Blue";
Console.WriteLine("After modifying the cloned car's color:");

Console.WriteLine("Original Car:" + originalCar);
Console.WriteLine("Cloned Car:" + clonedCar);