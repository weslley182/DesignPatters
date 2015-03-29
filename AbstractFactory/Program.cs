
using AbstractFactory.Classes;
using System;

namespace AbstractFactory
{
    class Program
    {
        // Cliente
        static void Main(string[] args)
        {
            var con = new SQLConnection();
            con.Open();

            var cmd = new SQLCommand();
            cmd.Execute();
            Console.ReadLine();

            // new [NomeFabrica] -> poderia vir de um aquivo de configuração
        //    DBFactory db = new OracleFactory();
        //    var con = db.createConnection();
        //    con.Open();
        //    var cmd = db.createCommand();
        //    cmd.Execute();
        //    Console.ReadLine();
        }
    }
}
