namespace Patterns.AbstractFactory.Interfaces.Products
{
    public abstract class ProductSofa: IProduct
    {
        public string Name { get; }
        public string Description { get; }
        public ProductSofa()
        {
            Name = "sofa";
            Description = $"This {Name} was created in {DateTime.Today}";
        }
        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}";
        }
        public abstract void SitDown();
        public abstract void Request();
    }
}
