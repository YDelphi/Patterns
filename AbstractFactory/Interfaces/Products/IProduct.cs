
namespace Patterns.AbstractFactory.Interfaces.Products
{
    public interface IProduct
    {
        string Name { get; }
        string Description { get; }
        public void SitDown();
        public void Request();
    }
}
