namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ایجاد عناصر زنجیره
            ComplaintHandler lowLevelHandler = new LowLevelHandler();
            ComplaintHandler midLevelHandler = new MidLevelHandler();
            ComplaintHandler highLevelHandler = new HighLevelHandler();
            //تنظیم زنجیره
            lowLevelHandler.SetNextHandler(midLevelHandler);
            midLevelHandler.SetNextHandler(highLevelHandler);
            //ارسال شکایت به زنجیره
            lowLevelHandler.HandleComplaint("Complaint 1", 1);
            //باید توسط MidLevelHandler پردازش شود
            lowLevelHandler.HandleComplaint("Complaint 2", 2);
            //باید توسط HighLevelHandler پردازش شود
            lowLevelHandler.HandleComplaint("Complaint 3", 4);
        }
    }
}