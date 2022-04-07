
namespace Patterns.AbstractFactory.Products
{
    public class Table
    {
        public string Name { get; }
        public string Description { get; }
        public Table()
        {
            Name = "Table";
            Description = $"This {Name} was created in {DateTime.Today}";
        }
        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}";
        }
    }
}
