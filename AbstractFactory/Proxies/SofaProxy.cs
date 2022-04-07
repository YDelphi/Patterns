using Patterns.AbstractFactory.Interfaces.Products;
using Patterns.AbstractFactory.Products;

namespace Patterns.AbstractFactory.Proxies
{
    public class SofaProxy : ProductSofa
    {
        private Sofa? _sofa;
        public override void SitDown() => throw new NotImplementedException();
        public override void Request()
        {
            if( _sofa == null)
            {
                _sofa = new Sofa();
            }
        }
    }
}
