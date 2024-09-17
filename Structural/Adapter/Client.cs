//استفاده میکند ITargetکه از کلاس Client
namespace Adapter
{
    internal class Client
    {
        private readonly ITarget _target;
        public Client(ITarget target)
        {
            _target = target;
        }
        public void Execute()
        {
            _target.Request();
        }
    }
}
