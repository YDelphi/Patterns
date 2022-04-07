using Patterns.AbstractFactory.Interfaces.Factory;
using Patterns.AbstractFactory.Interfaces.Products;
using Patterns.AbstractFactory.Products;

namespace Patterns.AbstractFactory.Factories
{
    public class RetroFactory : FurnitureFactory
    {
        private static RetroFactory? _instance;
        private RetroFactory() { }
        public static RetroFactory GetInstance()
        {
            if(_instance == null)
            {
                _instance = new RetroFactory();
                Console.WriteLine("Created retro factory");
            }
            return _instance;
        }
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
