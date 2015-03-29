
namespace AbstractFactory.Classes
{
    // Fábrica Abstrata (Abstract Factory)
    public abstract class DBFactory
    {
        public abstract DBConexao createConnection();
        public abstract DBCommand createCommand();
    }
}
