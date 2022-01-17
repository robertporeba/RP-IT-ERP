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

        public void DeleteRaportType(int raportTypeId)
        {
            var raportType = _context.RaportTypes.Find(raportTypeId);
            if (raportType != null)
            {
                _context.RaportTypes.Remove(raportType);
                _context.SaveChanges();
            }
        }

        public IQueryable<RaportType> GetAllRaportTypes()
        {
            var raportTypes = _context.RaportTypes;
            return raportTypes;
        }
    }
}