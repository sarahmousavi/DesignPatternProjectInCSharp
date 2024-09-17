using Builder;

//ساخت یک کامپیوتر گیمینگ
IComputerBuilder gamingBuilder =new GamingComputerBuilder();
ComputerDirector director=new ComputerDirector(gamingBuilder);
director.BuildComputer();
Computer gamingComputer=director.GetComputer();
Console.WriteLine("Gaming computer:" +gamingComputer);

//ساخت یک کامپیوتر اداری
IComputerBuilder officeBuilder = new OfficeComputerBuilder();
director=new ComputerDirector(officeBuilder);
director.BuildComputer();
Computer officeComputer = director.GetComputer();
Console.WriteLine("Office computer:" + officeComputer);