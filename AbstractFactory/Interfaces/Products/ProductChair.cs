namespace Patterns.AbstractFactory.Interfaces.Products
{
    public abstract class ProductChair: IProduct
    {
        public string Name { get; }
        public string Description { get; }
        public ProductChair()
        {
            Name = "Chair";
            Description = $"This {nameof(ProductChair)} was created in {DateTime.Today}";
        }
        public abstract void SitDown();
        public abstract void Request();
    }
}
