
namespace Patterns.AbstractFactory.Products
{
    public class RetroTable
    {
        public string Name { get; }
        public string Description { get; }
        public RetroTable()
        {
            Name = "Retro table";
            Description = $"This {Name} was created in {DateTime.Today}";
        }
        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}";
        }
    }
}
