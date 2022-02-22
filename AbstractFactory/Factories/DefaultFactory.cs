using Patterns.AbstractFactory.Interfaces.Factory;
using Patterns.AbstractFactory.Products;

namespace Patterns.AbstractFactory.Factories
{
    internal class DefaultFactory : FurnitureFactory
    {
        public DefaultFactory() : base() { }
        public override ProductChair CreateChair()
        {
            AmountOfCreatedObjects++;
            return new Chair();
        }

        public override ProductSofa CreateSofa()
        {
            AmountOfCreatedObjects++;
            return new Sofa();
        }
    }
}
