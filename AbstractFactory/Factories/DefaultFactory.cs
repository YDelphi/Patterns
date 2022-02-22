using Patterns.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Factories
{
    internal class DefaultFactory : FurnitureFactory
    {
        public DefaultFactory() : base() { }
        public override ProductChair CreateChair()
        {
            AmountOfCreatedObjects++;
            return new Chair();
        }

        public override ProductSofa CreateSofa()
        {
            AmountOfCreatedObjects++;
            return new Sofa();
        }
    }
}
