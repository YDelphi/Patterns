using Patterns.AbstractFactory.Interfaces.Products;

namespace Patterns.AbstractFactory.Products
{
    public class RetroChair: ProductChair
    {
        public RetroChair() : base(){ }
        public override void SitDown() => Console.WriteLine("You're sitting well");
        public override void Request() => Console.WriteLine("Requested retro chair");
    }
}
