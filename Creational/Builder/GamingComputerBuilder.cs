

namespace Builder
{
    //پیاده سازی
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer=new Computer();
        
        public void SetGraphicCard()
        {
            _computer.GraphicCard="NVIDIA GeForce RTX 3080";
        }

        public void SetProcessor()
        {
            _computer.Processor="Intel Core i9";
        }

        public void SetRAM()
        {
            _computer.RAM="32GB";
        }

        public void SetStorage()
        {
            _computer.Storage="1TB SSD";
        }
        public Computer GetComputer()
        {
            return _computer;
        }
    }
}
