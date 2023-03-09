using EcoTravel_DAL.Entities;
using EcoTravel_DAL.Services;
using System;

namespace TestDAL
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientService clientserv = new ClientService();
            Client cli = new Client()
            {
                prenom = "Samuel",
                nom = "Legrain", 
                pays = "FR",
                telephone = "0312456789",
                email = "samuel@gmail.com",
                password = "test0123"
            };
            cli.idClient = clientserv.Insert(cli);

            Console.WriteLine(clientserv.Get(cli.idClient).prenom);
        }
    }
}
