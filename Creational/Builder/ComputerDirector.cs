

namespace Builder
{
    public class ComputerDirector
    {
        private IComputerBuilder _builder;
        public ComputerDirector(IComputerBuilder builder)
        {
            _builder = builder;
        }
        public void BuildComputer()
        {
            _builder.SetGraphicCard();
            _builder.SetProcessor();
            _builder.SetRAM();
            _builder.SetStorage();
        }
        public Computer GetComputer()
        {
            return _builder.GetComputer();
        }
    }
}

