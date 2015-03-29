using System;

namespace AbstractFactory.Classes
{
    // Produto Concreto (Concret Product)
    public class OracleConnection : DBConexao
    {
        public override void Open()
        {
            Console.WriteLine("Método Open de OracleConnection foi chamado");
        }
    }
}
