using Patterns.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Factories
{
    internal class RetroFactory : FurnitureFactory
    {
        public RetroFactory(): base() { }
        public override ProductChair CreateChair()
        {
            AmountOfCreatedObjects++;
            return new RetroChair();
        }

        public override ProductSofa CreateSofa()
        {
            AmountOfCreatedObjects++;
            return new RetroSofa();
        }
    }
}
