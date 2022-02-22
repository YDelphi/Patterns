using Patterns.AbstractFactory.Interfaces.Products;

namespace Patterns.AbstractFactory.Products
{
    public class Chair : ProductChair
    {
        public Chair() : base() { }
        public override void SitDown() => Console.WriteLine("You're sitting well");
    }
}
