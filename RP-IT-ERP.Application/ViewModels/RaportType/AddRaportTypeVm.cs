using AutoMapper;
using RP_IT_ERP.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application.ViewModels.RaportType
{
    public class AddRaportTypeVm : IMapFrom<RP_IT_ERP.Domain.Model.RaportType>
    {
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<RP_IT_ERP.Domain.Model.RaportType, AddRaportTypeVm>().ReverseMap();
        }
    }
}
