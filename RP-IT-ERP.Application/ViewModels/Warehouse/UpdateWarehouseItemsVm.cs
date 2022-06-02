﻿using AutoMapper;
using RP_IT_ERP.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application.ViewModels.Warehouse
{
    public class UpdateWarehouseItemsVm : IMapFrom<RP_IT_ERP.Domain.Model.Warehouse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<RP_IT_ERP.Domain.Model.Warehouse, UpdateWarehouseItemsVm>().ReverseMap();
        }
    }
}
