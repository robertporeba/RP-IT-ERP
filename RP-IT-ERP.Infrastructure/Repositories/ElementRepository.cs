using RP_IT_ERP.Domain.Interfaces;
using RP_IT_ERP.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Infrastructure.Repositories
{
    public class ElementRepository : IElementRepository
    {
        private readonly Context _context;
        public ElementRepository(Context context)
        {
            _context = context;
        }
        public int AddElement(Element element)
        {
            _context.Elements.Add(element);
            _context.SaveChanges();
            return element.Id;
        }
    }
}
