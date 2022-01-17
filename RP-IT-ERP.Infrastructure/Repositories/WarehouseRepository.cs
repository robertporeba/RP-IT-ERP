using RP_IT_ERP.Domain.Interfaces;
using RP_IT_ERP.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Infrastructure.Repositories
{
    class WarehouseRepository : IWarehouseRepository
    {
        private readonly Context _context;
        public WarehouseRepository(Context context)
        {
            _context = context;
        }
        public int AddWarehouseItem(Warehouse warehouseItem)
        {
            _context.Warehouses.Add(warehouseItem);
            _context.SaveChanges();
            return warehouseItem.Id;
        }

        public void DeleteWarehouseItem(int warehouseId)
        {
            var warehouseItem = _context.Warehouses.Find(warehouseId);
            if (warehouseItem != null)
            {
                _context.Warehouses.Remove(warehouseItem);
                _context.SaveChanges();
            }
        }

        public IQueryable<Warehouse> GetAllWarehouseItems()
        {
            var warehouseItems = _context.Warehouses;
            return warehouseItems;
        }

        public void UpdateWarehouseItem(Warehouse warehouse)
        {
            _context.Warehouses.Update(warehouse);
            _context.SaveChanges();
        }
    }
}
