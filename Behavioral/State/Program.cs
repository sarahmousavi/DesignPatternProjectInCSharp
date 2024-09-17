using State;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initial state is Off
            Context context = new Context(new OffState());

            //Change state to On
            context.Request(); //Output:The machine is now OFF.

            //Change state to Off
            context.Request(); //Output:The machine is now ON.
        }
    }
}