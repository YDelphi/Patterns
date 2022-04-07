using Patterns.AbstractFactory.Interfaces.Products;

namespace Patterns.AbstractFactory.Interfaces.Decorator
{
    public class AbstractProductDecorator:IProductDecorator
    {
        protected IProduct _product;

        public string Name => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public void SetProduct(IProduct product) => _product = product;
        public void Request()
        {
            if(_product == null)
            {

            }
        }

        public void SitDown()
        {
            throw new NotImplementedException();
        }
    }
}
