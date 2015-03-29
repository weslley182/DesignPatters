using System;

namespace AbstractFactory.Classes
{
    // Produto Concreto (Concrete Product)
    public class OracleCommand : DBCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Método Execute de OracleCommand foi chamado");
        }
    }
}
