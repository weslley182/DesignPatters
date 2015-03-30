using FactoryMethod.Classes;
using System;

namespace FactoryMethod
{
    // Client
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new FacebookCreator();
            creators[1] = new GoogleCreator();

            foreach (Creator c in creators)
            {
                Autenticacao aut = c.CreateInstance(); // Factory Method
                aut.Autenticar();
            }
            Console.ReadLine();
        }
    }
}
