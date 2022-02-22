using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Products
{
    public abstract class ProductSofa
    {
        public string Name { get; }
        public string InfoAboutCreation { get; }
        public ProductSofa()
        {
            Name = "sofa";
            InfoAboutCreation = $"This {nameof(ProductSofa)} was created in {DateTime.Today}";
        }
    }
}
