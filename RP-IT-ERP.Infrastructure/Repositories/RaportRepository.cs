using RP_IT_ERP.Domain.Interfaces;
using RP_IT_ERP.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Infrastructure.Repositories
{
    public class RaportRepository : IRaportRepository
    {
        private readonly Context _context;
        public RaportRepository(Context context)
        {
            _context = context;
        }
        public int AddRaport(Raport raport)
        {
            _context.Raports.Add(raport);
            _context.SaveChanges();
            return raport.Id;
        }

        public void DeleteRaport(int raportId)
        {
            var raport = _context.Raports.Find(raportId);
            if (raport != null)
            {
                _context.Raports.Remove(raport);
                _context.SaveChanges();
            }
        }

        public IQueryable<Raport> GetAllRaports()
        {
            var raports = _context.Raports;
            return raports;
        }

        public Raport GetRaport(int raportId)
        {
            var raport = _context.Raports.FirstOrDefault(a => a.Id == raportId);
            return raport;
        }
    }
}