﻿
using AbstractFactory.Classes;
using System;

namespace AbstractFactory
{
    class Program
    {
        // Cliente
        static void Main(string[] args)
        {
            //var con = new SQLConnection();
            //con.Open();
            //var cmd = new SQLCommand();
            //cmd.Execute();
            //Console.ReadLine();

            //new [NomeFabrica] -> poderia vir de um aquivo de configuração
            
            //Bastaria alterar a Fabrica
            //DBFactory db = new OracleFactory();

            DBFactory db = new SQLFactory();
            var con = db.createConnection();
            con.Open();
            var cmd = db.createCommand();
            cmd.Execute();
            Console.ReadLine();
        }
    }
}
