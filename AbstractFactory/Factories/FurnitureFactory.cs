using Patterns.AbstractFactory.Products;

namespace Patterns.AbstractFactory.Factories
{
    public abstract class FurnitureFactory
    {
        public string Name { get; }
        public int AmountOfCreatedObjects { get; protected set; }
        public FurnitureFactory()
        {
            AmountOfCreatedObjects = 0;
            Name = $"{nameof(FurnitureFactory)}";
        }
        public abstract ProductChair CreateChair();
        public abstract ProductSofa CreateSofa();
    }
}