

namespace Builder
{
    //کلاس محصول،(Product)
    public class Computer
    {
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GraphicCard { get; set; }

        public override string ToString()
        {
            return $"Processor:{Processor},RAM:{RAM}," +
                $"Storage:{Storage},Graphic Card:{GraphicCard}"; 
        }
    }
}
