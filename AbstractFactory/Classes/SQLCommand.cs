using System;

namespace AbstractFactory.Classes
{
    // Produto Concreto (Concrete Product)
    public class SQLCommand : DBCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Método Execute de SQLCommand foi chamado");
        }
    }
}
