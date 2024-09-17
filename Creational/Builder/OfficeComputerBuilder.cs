

namespace Builder
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();


        public void SetGraphicCard()
        {
            _computer.GraphicCard = "Integrated Intel Graphic";
        }

        public void SetProcessor()
        {
            _computer.Processor = "Intel Core i5";
        }

        public void SetRAM()
        {
            _computer.RAM = "16GB";
        }

        public void SetStorage()
        {
            _computer.Storage = "512GB SSD";
        }
        public Computer GetComputer()
        {
            return _computer;
        }

    }
}