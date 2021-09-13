using Demo.Principle.Solid.DIP.Entity;
using Demo.Principle.Solid.DIP.Interface.Repository;
using System;

namespace Demo.Principle.Solid.DIP.Repository
{
    public class ClientRepository : IClientRepository
    {
        public void SaveCient(Client client)
        {
            Console.WriteLine($"Id: {client.Id}, Nome: {client.Name}");

            Console.WriteLine("Cliente salvo!");
        }
    }
}
