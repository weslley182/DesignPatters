using Prototype.Classes;
using System;

namespace Prototype
{
    class Program
    {
        // Client
        static void Main(string[] args)
        {
            // cria um objeto protótipo e um clone
            Livro p1 = new Livro(1, "Design Patterns", 20.0);
            Livro c1 = (Livro)p1.Clone();
            Console.WriteLine("Clonado: " + c1.Descricao + " Preço: " + c1.Preco.ToString("c"));

            // cria um objeto protótipo e um clone
            DVD p2 = new DVD(1, "POO", 30.0);
            DVD c2 = (DVD)p2.Clone();
            Console.WriteLine("Clonado: " + c2.Descricao + " Preço: " + c2.Preco.ToString("c"));
            Console.ReadLine();
        }
    }
}
