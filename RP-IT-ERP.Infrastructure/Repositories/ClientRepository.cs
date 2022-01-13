using RP_IT_ERP.Domain.Interfaces;
using RP_IT_ERP.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly Context _context;
        public ClientRepository(Context context)
        {
            _context = context;
        }
        public int AddClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
            return client.Id;
        }

        public void DeleteClient(int clientId)
        {
            var client = _context.Clients.Find(clientId);
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
        }

        public IQueryable<Client> GetAllClients()
        {
            var clients = _context.Clients;
            return clients;
        }

        public Client GetClient(int clientId)
        {
            var client = _context.Clients.FirstOrDefault(a => a.Id == clientId);
            return client;
        }

        public void UpdateClient(Client client)
        {
            _context.Clients.Update(client);
            _context.SaveChanges();
        }
    }
}
