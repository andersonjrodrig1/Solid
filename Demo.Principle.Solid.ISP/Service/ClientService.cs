using Demo.Principle.Solid.ISP.Entity;
using Demo.Principle.Solid.ISP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Principle.Solid.ISP.Service
{
    public class ClientService : IClientService
    {
        public void RegisterClient(Client client)
        {
            Console.WriteLine("Cliente cadastrado com sucesso!");
        }

        public bool ValidateData(Client client)
        {
            Console.WriteLine("Cliente validado!");

            return true;
        }
    }
}
