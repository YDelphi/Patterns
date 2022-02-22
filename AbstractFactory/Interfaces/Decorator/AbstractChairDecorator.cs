using Patterns.AbstractFactory.Interfaces.Products;

namespace Patterns.AbstractFactory.Interfaces.Decorator
{
    public abstract class AbstractChairDecorator : ProductChair
    {
        protected ProductChair? _product;
        public void SetProduct(ProductChair product) => _product = product;
        public override void SitDown()
        {
            if (_product != null)
            {
                _product.SitDown();
            }
        }
    }
}
