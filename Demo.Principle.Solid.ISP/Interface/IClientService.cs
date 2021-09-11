using Demo.Principle.Solid.ISP.Entity;

namespace Demo.Principle.Solid.ISP.Interface
{
    public interface IClientService
    {
        bool ValidateData(Client client);
        void RegisterClient(Client client);
    }
}
