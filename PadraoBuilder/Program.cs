using PadraoBuilder.Classes;
using System;

namespace PadraoBuilder
{
    class Program
    {
        // Client
        static void Main(string[] args)
        {
            VeiculoBuilder builder;
            var director = new Director();
            // cria produto
            builder = new CarroBuilder();
            director.Construct(builder);
            builder.Veiculo.Mostrar();
            // cria produto
            builder = new MotoBuilder();
            director.Construct(builder);
            builder.Veiculo.Mostrar();
            Console.ReadLine();
        }
    }
}
