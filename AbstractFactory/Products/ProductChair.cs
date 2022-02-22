using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Products
{
    public abstract class ProductChair
    {
        public string Name { get; }
        public string InfoAboutCreation { get; }
        public ProductChair()
        {
            Name = "Chair";
            InfoAboutCreation = $"This {nameof(ProductChair)} was created in {DateTime.Today}";
        }
    }
}
