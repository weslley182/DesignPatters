using System;

namespace AbstractFactory.Classes
{  // Produto Concreto (Concret Product)
    public class SQLConnection : DBConexao
    {
        public override void Open()
        {
            Console.WriteLine("Método Open de SQLConnection foi chamado");
        }
    }
}
