namespace Patterns.AbstractFactory.Interfaces.Factory
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