using Patterns.AbstractFactory.Interfaces.Factory;
using Patterns.AbstractFactory.Products;

namespace Patterns.AbstractFactory.Factories
{
    public class RetroFactory : FurnitureFactory
    {
        public RetroFactory(): base() { }
        public override ProductChair CreateChair()
        {
            AmountOfCreatedObjects++;
            return new RetroChair();
        }

        public override ProductSofa CreateSofa()
        {
            AmountOfCreatedObjects++;
            return new RetroSofa();
        }
    }
}
