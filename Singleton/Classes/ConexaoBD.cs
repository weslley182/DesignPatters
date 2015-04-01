using System;

namespace Singleton.Classes
{
    // Singleton
    public class ConexaoBD
    {
        // guarda internamente a instância        
        private static ConexaoBD _instance;
        // esconde construtor
        protected ConexaoBD()
        {
            //Nao consegue usar o new mais
        }

        // método que retorna singleton
        public static ConexaoBD Instance()
        {
            // garantir que sempre uma instância exista, só uma
            if (_instance == null)
            {
                _instance = new ConexaoBD();
            }

            return _instance;
        }

        public string stringConexao { get; set; }

        public void Open()
        {
            Console.WriteLine("Abrindo conexão com banco " + stringConexao);
        }
    }
}
