using Singleton.Classes;
using System;

namespace Singleton
{
    // Client
    class Program
    {
        static void Main(string[] args)
        {
            var con1 = ConexaoBD.Instance();
            con1.stringConexao = "SQL Server";
            con1.Open();

            var con2 = ConexaoBD.Instance();
            con2.Open();

            // comprovando que são a mesma instância
            if (con1 == con2) // está referenciado a mesma posição de memória, apontando para o mesmo objeto?
                Console.WriteLine("São a mesma instância");
            Console.ReadLine();
        }
    }
}
