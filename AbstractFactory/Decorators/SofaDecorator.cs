using Patterns.AbstractFactory.Interfaces.Decorator;

namespace Patterns.AbstractFactory.Decorators
{
    public class SofaDecorator: AbstractSofaDecorator
    {
        public override void SitDown()
        {
            base.SitDown();
        }
    }
}
