using Bridge;

namespace Bridge
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ایجاد یک تلوزیون و یک ریموت کنترل پیشرفته
            IDevice tv = new TV();
            RemoteControl remoteControl = new AdvanceRemoteControl(tv);

            //استفاده از ریموت کنترل
            remoteControl.TurnOn();
            ((AdvanceRemoteControl)remoteControl).SetChannel(5);
            remoteControl.TurnOff();

            //ایجاد یک رادیو و یک ریموت کنترل پیشرفته
            IDevice radio = new Radio();
            remoteControl = new AdvanceRemoteControl(radio);

            //استفاده از ریموت کنترل
            remoteControl.TurnOn();
            ((AdvanceRemoteControl)remoteControl).SetChannel(101);
            remoteControl.TurnOff();
        }
    }
}