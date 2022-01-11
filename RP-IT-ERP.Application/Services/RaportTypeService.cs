using AutoMapper;
using RP_IT_ERP.Application.Interfaces;
using RP_IT_ERP.Application.ViewModels.RaportType;
using RP_IT_ERP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application.Services
{
    public class RaportTypeService : IRaportTypeService
    {
        private readonly IRaportTypeRepository _raportTypeRepository;
        private readonly IMapper _mapper;
        public RaportTypeService(IMapper mapper, IRaportTypeRepository raportTypeRepository)
        {
            _raportTypeRepository = raportTypeRepository;
            _mapper = mapper;
        }

        public int AddRaportType(AddRaportTypeVm raportType)
        {
            var raportTypeDto = _mapper.Map<RP_IT_ERP.Domain.Model.RaportType>(raportType);
            var id = _raportTypeRepository.AddRaportType(raportTypeDto);
            return id;
        }
    }
}
