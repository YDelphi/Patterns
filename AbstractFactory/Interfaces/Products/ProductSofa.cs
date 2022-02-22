namespace Patterns.AbstractFactory.Interfaces.Products
{
    public abstract class ProductSofa: IProduct
    {
        public string Name { get; }
        public string Description { get; }
        public ProductSofa()
        {
            Name = "sofa";
            Description = $"This {nameof(ProductSofa)} was created in {DateTime.Today}";
        }
        public abstract void SitDown();
        public abstract void Request();
    }
}
