using RP_IT_ERP.Domain.Interfaces;
using RP_IT_ERP.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Infrastructure.Repositories
{
    public class RaportTypeRepository : IRaportTypeRepository
    {
        private readonly Context _context;
        public RaportTypeRepository(Context context)
        {
            _context = context;
        }
        public int AddRaportType(RaportType raportType)
        {
            _context.RaportTypes.Add(raportType);
            _context.SaveChanges();
            return raportType.Id;
        }
    }
}
