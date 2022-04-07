using Patterns.AbstractFactory.Interfaces.Products;

namespace Patterns.AbstractFactory.Interfaces.Factory
{
    public abstract class FurnitureFactory
    {
        public string Name { get; }
        public static int AmountOfCreatedObjects = 0;
        public FurnitureFactory()
        {
            Name = $"{nameof(FurnitureFactory)}";
        }
        public abstract ProductChair CreateChair();
        public abstract ProductSofa CreateSofa();
    }
}