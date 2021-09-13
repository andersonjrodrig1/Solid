using Demo.Principle.Solid.DIP.Entity;
using Demo.Principle.Solid.DIP.Interface.Repository;
using Demo.Principle.Solid.DIP.Interface.Service;

namespace Demo.Principle.Solid.DIP.Service
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void SaveClient(int id, string name)
        {
            var client = new Client
            {
                Id = id,
                Name = name
            };

            _clientRepository.SaveCient(client);
        }
    }
}
