using System;

namespace FactoryMethod.Classes
{
    // Produto Concreto
    public class AutenticacaoFacebook : Autenticacao
    {
        public override void Autenticar()
        {
            Console.WriteLine("Autenticado via Facebook");
        }
    }
}
