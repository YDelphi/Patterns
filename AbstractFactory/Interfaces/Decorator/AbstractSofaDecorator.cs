using Patterns.AbstractFactory.Interfaces.Products;

namespace Patterns.AbstractFactory.Interfaces.Decorator
{
    public abstract class AbstractSofaDecorator : ProductSofa
    {
        protected ProductSofa? _product;
        public void SetProduct(ProductSofa product) => _product = product;
        public override void SitDown()
        {
            if (_product != null)
            {
                _product.SitDown();
            }
        }
    }
}
