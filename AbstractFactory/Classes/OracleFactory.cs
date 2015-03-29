
namespace AbstractFactory.Classes
{
    // Fábrica Concrete (Concrete Fabric)
    public class OracleFactory : DBFactory
    {
        public override DBConexao createConnection()
        {
            return new OracleConnection();
        }

        public override DBCommand createCommand()
        {
            return new OracleCommand();
        }
    }
}
