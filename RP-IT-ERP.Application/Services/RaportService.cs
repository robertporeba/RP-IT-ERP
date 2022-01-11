using AutoMapper;
using RP_IT_ERP.Application.Interfaces;
using RP_IT_ERP.Application.ViewModels.Raport;
using RP_IT_ERP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_IT_ERP.Application.Services
{
    public class RaportService : IRaportService
    {
        private readonly IRaportRepository _raportRepository;
        private readonly IMapper _mapper;
        public RaportService(IMapper mapper, IRaportRepository raportRepository)
        {
            _raportRepository = raportRepository;
            _mapper = mapper;
        }

        public int AddRaport(AddRaportVm raport)
        {
            var raportDto = _mapper.Map<RP_IT_ERP.Domain.Model.Raport>(raport);
            var id = _raportRepository.AddRaport(raportDto);
            return id;
        }
    }
}
