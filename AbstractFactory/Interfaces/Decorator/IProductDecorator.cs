using Patterns.AbstractFactory.Interfaces.Products;

namespace Patterns.AbstractFactory.Interfaces.Decorator
{
    public interface IProductDecorator: IProduct
    {
        public void SetProduct(IProduct product);
    }
}
