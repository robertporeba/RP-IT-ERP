using AutoMapper;
using AutoMapper.QueryableExtensions;
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

        public void DeleteRaport(int raportId)
        {
            _raportRepository.DeleteRaport(raportId);
        }

        public ListGetRaportsVm GetAllRaports()
        {
            var raports = _raportRepository.GetAllRaports().ProjectTo<GetRaportVm>(_mapper.ConfigurationProvider).ToList();
            var raportsList = new ListGetRaportsVm()
            {
                Raports = raports
            };
            return raportsList;
        }

        public GetRaportVm GetRaport(int raportId)
        {
            var raport = _raportRepository.GetRaport(raportId);
            var raportVm = _mapper.Map<GetRaportVm>(raport);
            return raportVm;
        }
    }
}