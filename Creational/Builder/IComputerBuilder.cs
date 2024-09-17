

namespace Builder
{
    public interface IComputerBuilder
    {
        void SetProcessor();
        void SetRAM();
        void SetStorage();
        void SetGraphicCard();
        Computer GetComputer();

    }
}
