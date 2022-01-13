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

        public void DeleteElement(int elementId)
        {
            var element = _context.Elements.Find(elementId);
            if (element != null)
            {
                _context.Elements.Remove(element);
                _context.SaveChanges();
            }
        }

        public IQueryable<Element> GetAllElements()
        {
            var elements = _context.Elements;
            return elements;
        }

        public Element GetElement(int elementId)
        {
            var element = _context.Elements.FirstOrDefault(a => a.Id == elementId);
            return element;
        }

        public void UpdateElement(Element element)
        {
            _context.Elements.Update(element);
            _context.SaveChanges();
        }
    }
}