using Patterns.AbstractFactory.Interfaces.Products;

namespace Patterns.AbstractFactory.Products
{
    public class RetroSofa: ProductSofa
    {
        public RetroSofa(): base() { }
        public override void SitDown() => Console.WriteLine("You're sitting well");
        public override void Request() => Console.WriteLine("Requested retro sofa");
    }
}
