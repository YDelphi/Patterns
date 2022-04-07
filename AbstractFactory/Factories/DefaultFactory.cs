using Patterns.AbstractFactory.Interfaces.Factory;
using Patterns.AbstractFactory.Interfaces.Products;
using Patterns.AbstractFactory.Products;

namespace Patterns.AbstractFactory.Factories
{
    public class DefaultFactory : FurnitureFactory
    {
        private static DefaultFactory? _instance;
        private DefaultFactory() { }
        public static DefaultFactory GetInstance()
        {
            if(_instance == null)
            {
                _instance = new DefaultFactory();
                Console.WriteLine("Created default factory");
            }
            return _instance;
        }
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
