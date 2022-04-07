using Patterns.AbstractFactory.Interfaces.Decorator;
using Patterns.AbstractFactory.Products;

namespace Patterns.AbstractFactory.Decorators
{
    public class ChairDecorator: AbstractChairDecorator
    {
        public override void Request()
        {
            if(_product == null)
            {
                _product = new Chair();
            }
        }
        public override void SitDown()
        {
            base.SitDown();
        }
    }
}
