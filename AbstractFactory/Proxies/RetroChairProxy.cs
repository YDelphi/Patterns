using Patterns.AbstractFactory.Interfaces.Products;
using Patterns.AbstractFactory.Products;

namespace Patterns.AbstractFactory.Proxies
{
    public class RetroChairProxy: ProductChair
    {
        private RetroChair? _chair;
        public override void SitDown() => throw new NotImplementedException();
        public override void Request()
        {
            if (_chair == null)
            {
                _chair = new RetroChair();
            }
        }
    }
}
