using Command;

namespace CommandDesignPatternSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ایجاد دستگاه ها
            Light livingRoomLight = new Light();
            Television livingRoomTelevision = new Television();

            //ایجاد دستورات
            ICommand lightOn = new LightOnCommand(livingRoomLight);
            ICommand lightOff = new LightOffCommand(livingRoomLight);
            ICommand televisionOn = new TelevisionOnCommand(livingRoomTelevision);
            ICommand televisionOff = new TelevisionOffCommand(livingRoomTelevision);

            //ایجاد کنترل از راه دور
            RemoteControl remote = new RemoteControl();

            //اجرای دستورات
            remote.Submit(lightOn);//چراغ روشن 
            remote.Submit(televisionOn);//تلوزیون روشن
            remote.Undo();//آخرین دستور لغو می شود تلوزیون خاموش می شود
            remote.Submit(lightOff);//چراغ خاموش می شود
            remote.Undo();//آخرین دستور لغو می شود چراغ روشن می شود
        }
    }
}