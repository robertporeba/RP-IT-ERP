using AutoMapper;
using AutoMapper.QueryableExtensions;
using RP_IT_ERP.Application.Interfaces;
using RP_IT_ERP.Application.ViewModels.Warehouse;
using RP_IT_ERP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application.Services
{
    public class WarehouseService : IWarehouseService
    {
        private readonly IWarehouseRepository _warehouseRepository;
        private readonly IMapper _mapper;
        public WarehouseService(IMapper mapper, IWarehouseRepository warehouseRepository)
        {
            _warehouseRepository = warehouseRepository;
            _mapper = mapper;
        }

        public int AddWarehouseItem(AddWarehouseItemVm warehouseItem)
        {
            var warehouseDto = _mapper.Map<RP_IT_ERP.Domain.Model.Warehouse>(warehouseItem);
            var id = _warehouseRepository.AddWarehouseItem(warehouseDto);
            return id;
        }

        public void DeleteWarehouseItem(int warehouseId)
        {
            _warehouseRepository.DeleteWarehouseItem(warehouseId);
        }

        public ListGetWarehouseItemsVm GetAllWarehouseItems()
        {
            var warehouseItems = _warehouseRepository.GetAllWarehouseItems().ProjectTo<GetWarehouseItemsVm>(_mapper.ConfigurationProvider).ToList();
            var warehouseItemsList = new ListGetWarehouseItemsVm()
            {
                WarehauseItems = warehouseItems
            };
            return warehouseItemsList;
        }

        public void UpdateWarehouseItem(UpdateWarehouseItemsVm warehouse)
        {
            var warehouseItemDto = _mapper.Map<RP_IT_ERP.Domain.Model.Warehouse>(warehouse);
            _warehouseRepository.UpdateWarehouseItem(warehouseItemDto);
        }
    }
}