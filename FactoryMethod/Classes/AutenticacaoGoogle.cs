using System;

namespace FactoryMethod.Classes
{
    // Produto Concreto
    public class AutenticacaoGoogle : Autenticacao
    {
        public override void Autenticar()
        {
            Console.WriteLine("Autenticado via Google");
        }
    }
}
