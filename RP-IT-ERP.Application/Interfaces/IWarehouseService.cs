using RP_IT_ERP.Application.ViewModels.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application.Interfaces
{
    public interface IWarehouseService
    {
        int AddWarehouseItem(AddWarehouseItemVm warehouseItem);
        //TODO
        void DeleteWarehouseItem(int warehouseId);
        ListGetWarehouseItemsVm GetAllWarehouseItems();
        void UpdateWarehouseItem(UpdateWarehouseItemsVm warehouse);
    }
}
