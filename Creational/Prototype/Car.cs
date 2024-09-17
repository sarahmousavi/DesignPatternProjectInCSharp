

namespace Prototype
{
    public class Car:ICarPrototype
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int EngineCapacity { get; set; }
        public Car(string model,string color,int engineCapacity)
        {
            this.Model = model;
            this.Color = color;
            this.EngineCapacity = engineCapacity;  
        }
        public ICarPrototype Clone()
        {
            return (ICarPrototype)MemberwiseClone();
        }
        public override string ToString()
        {
            return $"Model:{Model},Color:{Color},Engine Capacity:{EngineCapacity} cc";
        }
    }
}
