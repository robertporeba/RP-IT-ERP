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
    }
}
