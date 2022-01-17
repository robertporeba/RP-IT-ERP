using RP_IT_ERP.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Domain.Interfaces
{
    public interface IWarehouseRepository
    {
        int AddWarehouseItem(Warehouse warehouseItem);
        void DeleteWarehouseItem(int warehouseId);
        IQueryable<Warehouse> GetAllWarehouseItems();
        void UpdateWarehouseItem(Warehouse warehouse);
    }
}
