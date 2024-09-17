

namespace FactoryMethod
{
    public class DogFactory:AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }
}
