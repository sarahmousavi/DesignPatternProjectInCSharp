

namespace AbstractFactory
{
    //پیاده سازی های واقعی کارخانه
    public class ToyotaFactory : ICarFactory
    {
        public ISUV CreateSUV()
        {
            return new ToyotaSUV();
        }

        public ISedan CreateSedan()
        {
            return new ToyotaSedan();
        }
    }
}
