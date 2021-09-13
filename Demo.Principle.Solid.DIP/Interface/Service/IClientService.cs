using Demo.Principle.Solid.DIP.Entity;

namespace Demo.Principle.Solid.DIP.Interface.Service
{
    public interface IClientService
    {
        void SaveClient(int id, string name);
    }
}
