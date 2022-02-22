using Patterns.AbstractFactory.Interfaces.Decorator;

namespace Patterns.AbstractFactory.Decorators
{
    public class ChairDecorator: AbstractChairDecorator
    {
        public override void SitDown()
        {
            base.SitDown();
        }
    }
}
