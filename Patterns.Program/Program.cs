using Patterns.AbstractFactory;
using Patterns.AbstractFactory.Factories;
using Patterns.AbstractFactory.Interfaces.Factory;

namespace Patterns.Program
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var client = new Client();
            var factory = RetroFactory.GetInstance();
            var factory2 = RetroFactory.GetInstance();
            client.Create(factory);
            client.CreateTables(new TableRetroFactory(), new TableDefaultFactory());
            client.Run();
            Console.WriteLine(FurnitureFactory.AmountOfCreatedObjects);
        }
    }
}