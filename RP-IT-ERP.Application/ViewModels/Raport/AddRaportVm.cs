using AutoMapper;
using RP_IT_ERP.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application.ViewModels.Raport
{
    public class AddRaportVm : IMapFrom<RP_IT_ERP.Domain.Model.Raport>
    {
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public int RaportTypeId { get; set; }
        public string Body { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<RP_IT_ERP.Domain.Model.Raport, AddRaportVm>().ReverseMap();
        }
    }
}
