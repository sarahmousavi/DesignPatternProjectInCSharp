

namespace AbstractFactory
{
    //پیاده سازی واقعی محصولات برای تویوتا
    public class ToyotaSedan : ISedan
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Toyota Sedan:corolla");
        }
    }
}
