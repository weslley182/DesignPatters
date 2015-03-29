
namespace AbstractFactory.Classes
{
    // Fábrica Concreta (Concrete Fabric)
    public class SQLFactory : DBFactory
    {
        public override DBConexao createConnection()
        {
            return new SQLConnection();
        }

        public override DBCommand createCommand()
        {
            return new SQLCommand();
        }
    }
}
