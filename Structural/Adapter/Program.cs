using Adapter;

class program
{
    static void Main(string[] args)
    {
        Adaptee adaptee = new Adaptee();
        ITarget adapter=new Adapterr(adaptee);
        Client client=new Client(adapter);
        client.Execute();
    }
}