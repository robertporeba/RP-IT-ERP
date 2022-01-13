using RP_IT_ERP.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Domain.Interfaces
{
    public interface IClientRepository
    {
        int AddClient(Client client);
        void DeleteClient(int clientId);
        IQueryable<Client> GetAllClients();
        void UpdateClient(Client client);
        Client GetClient(int clientId);
    }
}
