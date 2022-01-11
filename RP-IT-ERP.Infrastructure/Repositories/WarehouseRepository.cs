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
    }
}
