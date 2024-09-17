

namespace AbstractFactory
{
    //پیاده سازی های واقعی کارخانه
    public class FordFactory : ICarFactory
    {
        public ISUV CreateSUV()
        {
            return new FordSUV();
        }

        public ISedan CreateSedan()
        {
            return new FordSedan();
        }
    }
}
