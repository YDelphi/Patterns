using Patterns.AbstractFactory.Interfaces.Products;

namespace Patterns.AbstractFactory.Products
{
    public class Sofa: ProductSofa
    {
        public Sofa() : base() { }
        public override void Request() => Console.WriteLine("Requested sofa");
        public override void SitDown() => Console.WriteLine("You're sitting well");
    }
}
