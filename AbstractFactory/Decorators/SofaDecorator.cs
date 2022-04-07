using Patterns.AbstractFactory.Interfaces.Decorator;
using Patterns.AbstractFactory.Products;

namespace Patterns.AbstractFactory.Decorators
{
    public class SofaDecorator: AbstractSofaDecorator
    {
        public override void Request()
        {
            if(_product == null)
            {
                _product = new Sofa();
            }
        }

        public override void SitDown()
        {
            base.SitDown();
        }
    }
}
