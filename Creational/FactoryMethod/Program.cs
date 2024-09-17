using FactoryMethod;
//ساخت یک کارخانه سگ
AnimalFactory dogFactory = new DogFactory();
IAnimal dog = dogFactory.CreateAnimal();
dog.Speak();//خروجی :Haap! Haap!

//ساخت یک کارخانه گربه
AnimalFactory catFactory = new CatFactory();
IAnimal cat = catFactory.CreateAnimal();
cat.Speak();//خروجی:Meow! Meow!