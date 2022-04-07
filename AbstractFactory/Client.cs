using Patterns.AbstractFactory.Factories;
using Patterns.AbstractFactory.Interfaces.Factory;
using Patterns.AbstractFactory.Interfaces.Products;
using Patterns.AbstractFactory.Products;

namespace Patterns.AbstractFactory
{
    public class Client
    {
        private ProductChair? _chair;
        private ProductSofa? _sofa;
        private Table? _table;
        private RetroTable? _retroTable;
        public Client()
        {
            _chair = null;
            _sofa = null;
            _retroTable = null;
            _table = null;
        }
        public ProductChair CreateChair(FurnitureFactory factory)
        {
            _chair = factory.CreateChair();
            return _chair;
        }
        public ProductSofa CreateSofa(FurnitureFactory factory)
        {
            _sofa = factory.CreateSofa();
            return _sofa;
        }
        public void Create(FurnitureFactory factory)
        {
            _chair = factory.CreateChair();
            _sofa = factory.CreateSofa();
        }
        public void Run()
        {
            Console.WriteLine(_chair?.ToString());
            Console.WriteLine(_sofa?.ToString());
            Console.WriteLine(_retroTable?.ToString());
            Console.WriteLine(_table?.ToString());
        }
        public void CreateTables(TableRetroFactory retro, TableDefaultFactory defaultt)
        {
            _retroTable = retro.CreateTable();
            _table = defaultt.CreateTable();
        }
    }
}
