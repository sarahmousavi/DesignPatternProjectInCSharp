namespace Adapter
{
    //AdapteeوItargetکه رابط بین کلاس Adapter
    public class Adapterr : ITarget
    {
        private readonly Adaptee _daptee;
        public Adapterr(Adaptee adaptee)
        {
            _daptee = adaptee;
        }
        public void Request()
        {
            _daptee.SpecificRequest();
        }
    }
}
